
using System.Security;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Implementation;
using TryBeingFit.Services.Interfaces;

//we want to make Program.cs depended on the interface, Program.cs uses a variable of type IUserServid=ce
//that ensures that the variable will always have the methods that are declared in the interface (ex.GetAllUsers())
//the impl depends on the type of the object that we assign to the variable
IUserService<StandardUser> standardUserService = new UserService<StandardUser>();
IUserService<PremiumUser> premiumUserService = new UserService<PremiumUser>();
IUserService<Trainer> trainerUserService = new UserService<Trainer>();
//IUserService<StandardUser> standardUserService = new SecondUserService<StandardUser>();

//standardUserService.GetAllUsers();
ITrainingService<LiveTraining> liveTrainingService = new TrainingService<LiveTraining>();
ITrainingService<VideoTraining> videoTrainingService = new TrainingService<VideoTraining>();

IUIService uIService = new UIService(); //we created this service in order to extract some methods related to input/outpu (user inteface) in a different service, so that our Program.cs is cleaner

Seed(); //put some inital data in the db

//Ask the user to choose an option (login/register)
Console.WriteLine("Choose an option 1) login 2) register");
string input = Console.ReadLine();

bool success = int.TryParse(input, out int userOption);
if (!success)
{
    throw new Exception("Invalid user option");
}

if(userOption != 1 && userOption != 2)
{
    throw new Exception("Invalid user option! You need to choose between 1 and 2");
}
User currentUser = null;
while (true)
{
    if (userOption == 1)
    {
        Console.WriteLine("Enter username");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password");
        string password = Console.ReadLine();

        Console.WriteLine("Enter your role: 1) Standard 2) Premium 3)Trainer");
        bool successInputRole = int.TryParse(Console.ReadLine(), out int roleOption);
        if (!successInputRole)
        {
            //throw new Exception("Invalid user role option");
            Console.WriteLine("Invalid user role option");
            continue;
        }
        if (roleOption < 1 || roleOption > 3)
        {
            //throw new Exception("Invalid user role option! You need to choose from option 1,2 or 3");
            Console.WriteLine("Invalid user role option! You need to choose from option 1,2 or 3");
            continue;
        }

        UserRoleEnum userRole = (UserRoleEnum)roleOption;


        switch (userRole)
        {
            case UserRoleEnum.Standard:
                //login for standard user
                currentUser = standardUserService.Login(username, password);
                break; //to end the switch
            case UserRoleEnum.Premium:
                //login for premium user
                currentUser = premiumUserService.Login(username, password);
                break;
            case UserRoleEnum.Trainer:
                //login for trainer
                currentUser = trainerUserService.Login(username, password);
                break;
            default:
                currentUser = null;
                break;
        }
        break; //to end the while loop
    }
    else if (userOption == 2)
    {
        //register

        //1. get the data
        StandardUser standardUser = uIService.FillRegisterData();

        //2. try to register the user
        //users can only register as standard users, so we call the register method from standardUserService
        //and we directly login the user after
        currentUser = standardUserService.RegisterUser(standardUser);
        break; //to end the loop
    }
    else
    {
        Console.WriteLine("Invalid option! You must choose between 1 or 2!");
        continue; //give another chance
    }
}

//Show main menu
string mainMenuOption = uIService.MainMenu(currentUser?.Role);

switch (mainMenuOption)
{
    case "Train":
        if(currentUser.Role == UserRoleEnum.Standard) {
            videoTrainingService.GetChosenTraining();
        
        }else if(currentUser.Role == UserRoleEnum.Premium || currentUser.Role == UserRoleEnum.Trainer)
        {
            Console.WriteLine("Enter option: 1) video 2) live");
            string trainingInput = Console.ReadLine();
            bool isValid = int.TryParse(trainingInput, out int trainingOption);
            if(!isValid)
            {
                throw new Exception("Wrong input");
            }
            switch(trainingOption)
            {
                case 1:
                    videoTrainingService.GetChosenTraining();
                    break;
                case 2:
                    liveTrainingService.GetChosenTraining();
                    break;
                default:
                    Console.WriteLine("Invalid training option");
                    break;
            }
        }
    break;
    case "Upgrade to premium":
        //1.(optional) validate that the user is a standard user. optional validation, because if the user is not a standard user he should not have the option to upgrade to premium
        if(currentUser.Role != UserRoleEnum.Standard)
        {
            throw new Exception("Only standard users can upgrade to premium");
        }

        //2. current user should not appear among standard users anymore and he/she should be a part of the premium users
        standardUserService.RemoveById(currentUser.Id);

        currentUser = premiumUserService.RegisterUser(new PremiumUser
        {
            FirstName = currentUser.FirstName,
            LastName = currentUser.LastName,
            Username = currentUser.Username,
            Password = currentUser.Password,
            Role = UserRoleEnum.Premium
        }); //we need to add the new user to the premium users db (our list)
        break;
    case "Reschedule a training":
        //validation (option)
        if(currentUser.Role != UserRoleEnum.Trainer)
        {
            throw new Exception("Current user is not a trainer");
        }

        LiveTraining liveTraining = liveTrainingService.GetChosenTraining();
        Console.WriteLine("Please enter days for reschedule");
        bool isValidDays = int.TryParse(Console.ReadLine(), out int days);
        if (!isValidDays)
        {
            throw new Exception("Invalid input");
        }

        //currently we only have our currentUser with the data from the user class
        //we need to call the method Reschule which is a method that is specific for our Trainer class
        //that means that we need to find our current user in the list of all trainers and call the Reschule method then
        List<Trainer> trainers = trainerUserService.GetAllUsers(); //get all trainers
        trainers.FirstOrDefault(x => x.Id == currentUser.Id)?.Reschedule(liveTraining, days); //call the reschedule method with the chosen live training and the number of days, for our trainer
        break;
    case "Account info":
        Console.WriteLine("Choose an option: 1) Change info 2) Change password");
        string option = Console.ReadLine();
        bool successAccount = int.TryParse(option, out int accountOption);
        if (!successAccount)
        {
            throw new Exception("Invalid user option");
        }
        if(accountOption == 1)
        {
            //change info 
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            //based on the role of the user we decide with which service to call the ChangeInfo method 
            switch (currentUser.Role)
            {
                case UserRoleEnum.Standard:
                    currentUser = standardUserService.ChangeInfo(currentUser.Id, firstName, lastName);
                    break;
                case UserRoleEnum.Premium:
                    currentUser = premiumUserService.ChangeInfo(currentUser.Id, firstName, lastName);
                    break;
                case UserRoleEnum.Trainer:
                    currentUser = trainerUserService.ChangeInfo(currentUser.Id, firstName, lastName);
                    break;
            }
        }
        else if(accountOption == 2)
        {
            Console.WriteLine("Enter old password");
            string oldPassword = Console.ReadLine();
            Console.WriteLine("Entrer new password");
            string newPassword = Console.ReadLine();
            switch (currentUser.Role)
            {
                case UserRoleEnum.Standard:
                    currentUser = standardUserService.ChangePassword(currentUser.Id, oldPassword, newPassword);
                    break;
                case UserRoleEnum.Premium:
                    currentUser = premiumUserService.ChangePassword(currentUser.Id, oldPassword, newPassword);
                    break;
                case UserRoleEnum.Trainer:
                    currentUser = trainerUserService.ChangePassword(currentUser.Id, oldPassword, newPassword);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid option");
        }
        break;
    case "Log out":
        currentUser = null;
        break;
}

void Seed(){
    StandardUser standardUser = new StandardUser();
    standardUser.FirstName = "Petko";
    standardUser.LastName = "Petkovski";
    standardUser.Username = "p.petko";
    standardUser.Password = "Test123!";

    PremiumUser premiumUser = new PremiumUser();
    premiumUser.FirstName = "Nikola";
    premiumUser.LastName = "Nikolovski";
    premiumUser.Username = "n.nikola";
    premiumUser.Password = "P@ssw0rd";

    Trainer trainer = new Trainer();
    trainer.FirstName = "Marko";
    trainer.LastName = "Markovski";
    trainer.Username = "m.marko";
    trainer.Password = "Test123";

    standardUserService.RegisterUser(standardUser);
    premiumUserService.RegisterUser(premiumUser);
    trainerUserService.RegisterUser(trainer);

    LiveTraining liveTraining = new LiveTraining();
    liveTraining.Title = "Yoga";
    liveTraining.Description = "Yoga training";
    liveTraining.Time = 30;
    liveTraining.TrainingDifficulty = TrainingDifficultyEnum.Medium;
    liveTraining.Trainer = trainer;
    liveTrainingService.AddTraining(liveTraining);
}
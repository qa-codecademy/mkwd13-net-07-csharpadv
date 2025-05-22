﻿
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

if(userOption == 1)
{
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();

    Console.WriteLine("Enter password");
    string password = Console.ReadLine();

    Console.WriteLine("Enter your role: 1) Standard 2) Premium 3)Trainer");
    bool successInputRole = int.TryParse(Console.ReadLine(), out int roleOption);
    if (!successInputRole)
    {
        throw new Exception("Invalid user role option");
    }
    if(roleOption <1 || roleOption > 3)
    {
        throw new Exception("Invalid user role option! You need to choose from option 1,2 or 3");
    }

    UserRoleEnum userRole = (UserRoleEnum)roleOption;
    User currentUser = null;

    switch (userRole)
    {
        case UserRoleEnum.Standard:
            //login for standard user
            currentUser = standardUserService.Login(username, password);
            break;
        case UserRoleEnum.Premium:
            //login for premium user
            currentUser = premiumUserService.Login(username,password);
            break;
        case UserRoleEnum.Trainer:
            //login for trainer
            currentUser = trainerUserService.Login(username, password);
            break;
        default:
            currentUser = null;
            break;
    }
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
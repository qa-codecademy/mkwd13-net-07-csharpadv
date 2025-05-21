
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Implementation;
using TryBeingFit.Services.Interfaces;

//we want to make Program.cs depended on the interface, Program.cs uses a variable of type IUserServid=ce
//that ensures that the variable will always have the methods that are declared in the interface (ex.GetAllUsers())
//the impl depends on the type of the object that we assign to the variable
IUserService<StandardUser> standardUserService = new UserService<StandardUser>();
//IUserService<StandardUser> standardUserService = new SecondUserService<StandardUser>();

//standardUserService.GetAllUsers();

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
}
using System.Security;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.Implementation
{
    public class UIService : IUIService
    {
        public StandardUser FillRegisterData()
        {

            string firstName = EnterData("first name");
            string lastName = EnterData("last name");
            string username = EnterData("username");
            string password = EnterData("password");
            string confirmPassword = EnterData("confirm password");

            if(password != confirmPassword)
            {
                throw new Exception("Passwords do not match!");
            }

            //if data is not empty, create the user that will be registered
            StandardUser standardUser = new StandardUser()
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
            };
            return standardUser;
        }

        public string MainMenu(UserRoleEnum? userRole)
        {
            if(userRole == null)
            {
                throw new Exception("Invalid user");
            }
            List<string> menuItems = new List<string>();
            menuItems.Add("Train");
            switch (userRole)
            {
                case UserRoleEnum.Standard:
                    menuItems.Add("Upgrade to premium");
                    break;
                case UserRoleEnum.Trainer:
                    menuItems.Add("Reschedule a training");
                    break;
            }
            menuItems.Add("Account info");
            menuItems.Add("Log out");
            int numInput = 0; //we need to declare this here, because we need to use it both in the while and after
            while (true)
            {
                Console.WriteLine("Choose an option"); ;
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }

                string input = Console.ReadLine();

                bool isNumber = int.TryParse(input, out numInput);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number");
                    continue;
                }
                if (numInput < 1 || numInput > menuItems.Count)
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }
                break; //we want to end the loop if the option was okay
            }

            return menuItems[numInput - 1]; //if we choose the option 1. Train, that means that we want the item with index 0 (numInput - 1)
        }

        private string EnterData(string field)
        {
            while (true)
            {
                Console.WriteLine($"Please enter {field}");
                string data = Console.ReadLine();
                if(string.IsNullOrEmpty(data)) {

                    Console.WriteLine($"You must enter {field}");
                    continue;
                }
                else
                {
                    return data;
                }
            }
          
        }
    }
}

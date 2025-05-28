using TaxiManager9000.Domain.Models;
using TaxiManager9000.Helpers;
using TaxiManager9000.Services.Abstraction.Interfaces;

namespace TaxiManager9000.Services.Implementation
{
    public class UIService : IUIService
    {
        public int ChooseMenu<T>(List<T> menus)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {menus[i]}");
            }
            int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), menus.Count);
            return choice;
        }

        public User LoginMenu()
        {
            Console.Clear();
            ExtendedConsole.PrintInColor("\nEnter your credentials:", ConsoleColor.Cyan);
            string username = ExtendedConsole.GetInput("Username: ");
            string password = ExtendedConsole.GetInput("Password: ");

            if (!ValidationHelper.ValidateStringInput(username) ||
                !ValidationHelper.ValidateStringInput(password))
            {
                throw new Exception("Please enter valid inputs !");
            }

            return new User
            {
                Username = username,
                Password = password
            };
        }
    }
}

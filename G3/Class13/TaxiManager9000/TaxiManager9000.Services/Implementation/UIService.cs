using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Helpers;
using TaxiManager9000.Helpers.Extensions;
using TaxiManager9000.Services.Abstraction.Interfaces;
using TaxiManager9000.Services.Enums;

namespace TaxiManager9000.Services.Implementation
{
    public class UIService : IUIService
    {
        public List<MenuChoice> MenuItems { get; set; }

        /// <summary>
        /// Displays a menu of items from a list and prompts the user to choose an item by entering a number corresponding to the item.
        /// </summary>
        /// <typeparam name="T">The type of items in the list.</typeparam>
        /// <param name="items">A list of items to be displayed in the menu.</param>
        /// <returns>An integer representing the index of the chosen item in the list or -1 if invalid choice was made.</returns>
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

        public int MainMenu(Role role)
        {
            while (true)
            {
                Console.Clear();
                ExtendedConsole.PrintTitle($"\n\t*** {role.ToString().ToUpper()} MENU ***\n\n");
                MenuItems = GetMenuOptionsForRole(role);
                int userChoice = ChooseMenu(MenuItems.Select(m => m.ToString().ToSeparateString()).ToList());
                if (userChoice == -1)
                {
                    ExtendedConsole.PrintError("Invalid choice! Try again...");
                    continue;
                }
                return userChoice;
            }
        }

        /// <summary>
        ///  Retrieves the menu options available for a specific role.
        /// </summary>
        /// <param name="role">The role for which to retrieve the menu options.</param>
        /// <returns>A list of menu choices available for the specified role.</returns>
        private List<MenuChoice> GetMenuOptionsForRole(Role role)
        {
            return role switch
            {
                Role.Administrator => new List<MenuChoice>
                    {
                        MenuChoice.AddNewUser,
                        MenuChoice.RemoveExistingUser,
                        MenuChoice.ChangePassword,
                        MenuChoice.Exit,
                    },
                Role.Manager => new List<MenuChoice>
                    {
                        MenuChoice.ListAllDrivers,
                        MenuChoice.TaxiLicenseStatus,
                        MenuChoice.DriverManager,
                        MenuChoice.ChangePassword,
                        MenuChoice.Exit,
                    },
                Role.Maintenance => new List<MenuChoice>
                    {
                        MenuChoice.ListAllCars,
                        MenuChoice.LicensePlateStatus,
                        MenuChoice.ChangePassword,
                        MenuChoice.Exit,
                    },
                _ => Enumerable.Empty<MenuChoice>().ToList(),
            };
        }

        public void EndMenu()
        {
            Console.Clear();
            ExtendedConsole.PrintTitle("\n\n\n\n\n\n                    *** THANK YOU FOR USING OUR APP ***");
            Console.ReadLine();
        }
    }
}

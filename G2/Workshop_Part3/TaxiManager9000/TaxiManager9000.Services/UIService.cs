using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Enums;
using TaxiManager9000.Services.Interfaces;
using TaxiManager9000.Services.Utilities;

namespace TaxiManager9000.Services
{
    public class UIService : IUIService
    {
        private List<MenuChoice> _menuItems;
        public List<MenuChoice> MenuItems 
        {
            get => _menuItems;
            set
            {
                if(_menuItems != null)
                {
                    _menuItems.Clear();
                }

                _menuItems = value;
            }
        }
        public void Welcome(User user)
        {
            Console.WriteLine($"Welcome {user.Role} user!");
        }
        public User LogInMenu()
        {
            Console.WriteLine("Taxi Manager 9000");
            ExtendedConsole.Separator();
            Console.WriteLine("Log in:");
            string username = ExtendedConsole.GetInput("Username:");
            string password = ExtendedConsole.GetInput("Password:");

            return new User { Username = username, Password = password };
        }
        public int MainMenu(Role role)
        {
            var menuItems = new List<MenuChoice>() { MenuChoice.ChangePassword, MenuChoice.Exit};

            switch (role)
            {
                case Role.Admin:
                    menuItems = menuItems.Prepend(MenuChoice.AddNewUser).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.RemoveExistingUser).ToList();
                    break;
                case Role.Manager:
                    menuItems = menuItems.Prepend(MenuChoice.ListAllDrivers).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.TaxiLicenseStatus).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.DriverManager).ToList();
                    break;
                case Role.Maintenance:
                    menuItems = menuItems.Prepend(MenuChoice.ListAllCars).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.LicensePlateStatus).ToList();
                    break;
            }
            MenuItems = menuItems;
            return ChooseMenu(MenuItems);
        }
        public int ChooseMenu<T>(List<T> items)
        {
            Console.Clear();
            if(items.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<T>();
                Console.ReadLine();
                return -1;
            }

            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i +1} {items[i]}");
                }
                int choice = StringValidator.ValidateNumber(Console.ReadLine(), items.Count);
                if(choice == -1)
                {
                    ExtendedConsole.WriteLine($"[Error] Input incorrect. Please try again", ConsoleColor.Red);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                return choice;
            }
        }
        public int ChooseEntitiesMenu<T>(List<T> entities) where T : BaseEntity
        {
            Console.Clear();
            if (entities.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<T>();
                Console.ReadLine();
                return -1;
            }

            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < entities.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {entities[i].Print()}");
                }
                int choice = StringValidator.ValidateNumber(Console.ReadLine(), entities.Count);
                if (choice == -1)
                {
                    ExtendedConsole.WriteLine($"[Error] Input incorrect. Please try again", ConsoleColor.Red);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                return choice;
            }
        }

    }
}

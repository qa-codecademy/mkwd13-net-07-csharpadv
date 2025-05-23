using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Helpers;
using TaxiManager9000.Services.Abstraction.Interfaces;
using TaxiManager9000.Services.Implementation;

namespace TaxiManager9000.App
{
    internal class TaxiManagerUI
    {
        private readonly IUIService _uiService;
        private readonly ICarService _carService;
        private readonly IUserService _userService;
        private readonly IDriverService _driverService;

        public TaxiManagerUI()
        {
            _uiService = new UIService();
            _carService = new CarService();
            _userService = new UserService();
            _driverService = new DriverService();
            InitializeStartingData();
        }

        public void InitApp()
        {
            while (true)
            {
                Console.Clear();

                #region Login Menu
                if (_userService.CurrentUser is null)
                {
                    try
                    {
                        ExtendedConsole.PrintTitle("\n\t*** Taxi Manager 9000 ***\n");
                        int choice = _uiService.ChooseMenu(new List<string> { "Login", "Exit" });
                        if (choice == -1)
                        {
                            ExtendedConsole.PrintError("Invalid choice! Try again...");
                            continue;
                        }
                        if (choice == 2)
                            break;

                        User inputUser = _uiService.LoginMenu();
                        _userService.LogIn(inputUser.Username, inputUser.Password);
                        ExtendedConsole.PrintSuccess($"\nWelcome {_userService.CurrentUser.Role} {_userService.CurrentUser.Username}");
                    }
                    catch (Exception ex)
                    {
                        ExtendedConsole.PrintError($"\n{ex.Message}");
                        continue;
                    }
                }

                #endregion
            }
        }

        /// <summary>
        ///     Method used for seeding database data
        /// </summary>
        private void InitializeStartingData()
        {
            User administrator = new User("bob123", "bob123", Role.Administrator);
            User manager = new User("JillWayne", "jillawesome1", Role.Manager);
            User maintenances = new User("GregGregsky", "supergreg1", Role.Maintenance);
            List<User> seedUsers = new List<User>() { administrator, manager, maintenances };
            _userService.Seed(seedUsers);

            Car car1 = new Car("Auris (Toyota)", "AFW950", new DateTime(2023, 12, 1));
            Car car2 = new Car("Auris (Toyota)", "CKE480", new DateTime(2021, 10, 15));
            Car car3 = new Car("Transporter (Volkswagen)", "GZDR69", new DateTime(2024, 5, 30));
            Car car4 = new Car("Mondeo (Ford)", "5RIP283", new DateTime(2022, 5, 13));
            Car car5 = new Car("Premier (Peugeot)", "2AR9907", new DateTime(2022, 11, 9));
            Car car6 = new Car("Vito (Mercedes)", "6RND294", new DateTime(2023, 3, 11));
            List<Car> seedCars = new List<Car>() { car1, car2, car3, car4, car5, car6 };
            _carService.Seed(seedCars);

            Driver driver1 = new Driver("Romario", "Walsh", Shift.NoShift, null, "LC12456123", new DateTime(2023, 11, 5));
            Driver driver2 = new Driver("Kathleen", "Rankin", Shift.Morning, car1, "LC54435234", new DateTime(2022, 1, 12));
            Driver driver3 = new Driver("Ashanti", "Mooney", Shift.Evening, car1, "LC65803245", new DateTime(2022, 5, 19));
            Driver driver4 = new Driver("Zakk", "Hook", Shift.Afternoon, car1, "LC20897583", new DateTime(2023, 9, 28));
            Driver driver5 = new Driver("Xavier", "Kelly", Shift.NoShift, null, "LC15636280", new DateTime(2024, 6, 1));
            Driver driver6 = new Driver("Joy", "Shelton", Shift.Evening, car2, "LC47845611", new DateTime(2023, 7, 3));
            Driver driver7 = new Driver("Kristy", "Riddle", Shift.Morning, car3, "LC19006543", new DateTime(2024, 6, 12));
            Driver driver8 = new Driver("Stuart", "Mayer", Shift.Evening, car3, "LC53187767", new DateTime(2023, 10, 10));
            List<Driver> seedDrivers = new List<Driver>() { driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8 };
            _driverService.Seed(seedDrivers);
        }
    }
}

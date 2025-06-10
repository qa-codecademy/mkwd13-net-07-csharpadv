#region Setup

using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services;
using TaxiManager9000.Services.Enums;
using TaxiManager9000.Services.Interfaces;
using TaxiManager9000.Services.Utilities;

IUIService uiService = new UIService();
IDriverService driverService = new DriverService();

UserAdoService userAdoService = new UserAdoService();


IUserService userService = new UserService();
ICarService carService = new CarService();

InitializeStartingData();
#endregion

while (true)
{
    #region LogIn
    Console.Clear();
    if (userService.CurrentUser == null)
    {
        try
        {
            User inputUser = uiService.LogInMenu();
            userService.LogIn(inputUser.Username, inputUser.Password);
            uiService.Welcome(userService.CurrentUser);
        }
        catch (Exception ex)
        {
            ExtendedConsole.WriteLine(ex.Message, ConsoleColor.Red);
            Console.ReadLine();
            continue;
        }
    }
    #endregion

    #region Menu
    int menuChoiseNumber = uiService.MainMenu(userService.CurrentUser.Role);
        if (menuChoiseNumber == -1) continue;
        MenuChoice menuChoice = uiService.MenuItems[menuChoiseNumber - 1];
        switch (menuChoice)
        {
            case MenuChoice.AddNewUser:
                string username = ExtendedConsole.GetInput("Username:");
                string password = ExtendedConsole.GetInput("Password:");
                if(!StringValidator.ValidateUsername(username) || !StringValidator.ValidatePassword(password))
                {
                    ExtendedConsole.WriteLine("Add failed.", ConsoleColor.Red);
                    Console.ReadLine();
                    continue;
                }
                int role = uiService.ChooseMenu(new List<string>()
                {
                    "Admin", "Manager", "Maintenance"
                });
                User newUser = new User(username, password, (Role)role);
                userService.Add(newUser);
                ExtendedConsole.WriteLine("User is succ added in database", ConsoleColor.Green);
                break;
            case MenuChoice.RemoveExistingUser:
                //List<User> users = userService.GetAll().Where(x=> x.Id != userService.CurrentUser.Id).ToList();
                List<User> users = (await userAdoService.GetAllUsers()).Where(x=> x.Id != userService.CurrentUser.Id).ToList();
            int choise = uiService.ChooseEntitiesMenu(users);
                if (choise == -1) continue;

                userService.Remove(users[choise-1].Id);
                ExtendedConsole.WriteLine("User is succ removed from database", ConsoleColor.Green);
                break;
            case MenuChoice.ListAllDrivers:
                driverService.GetAll().Print();
                break;
            case MenuChoice.TaxiLicenseStatus:
                driverService.GetAll().PrintStatus();
                break;
            case MenuChoice.ListAllCars:
                carService.GetAll().Print(); 
                break;
            case MenuChoice.LicensePlateStatus:
                carService.GetAll().PrintStatus();
                break;
            case MenuChoice.DriverManager:
                List<DriverManagerChoise> driverMangerMenu = new List<DriverManagerChoise>() { DriverManagerChoise.AssigneDriver, DriverManagerChoise.UnassigneDriver
                    };
                int driverChoice = uiService.ChooseMenu(driverMangerMenu);

                List<Driver> availableDriver = driverService.GetAll(x=> driverService.IsAvailableDriver(x));

                if(driverChoice == 1)
                {
                    List<Driver> availableForAssigneDrivers = availableDriver.Where(x=>x.Car == null).ToList();

                    int assigneDriverChoise = uiService.ChooseEntitiesMenu(availableForAssigneDrivers);

                    if (assigneDriverChoise == -1) continue;

                    List<Car> availableForAssigneCars = carService.GetAll(x => carService.IsAvailableCar(x));

                    int assigneCarChoise = uiService.ChooseEntitiesMenu(availableForAssigneCars);
                    if (assigneCarChoise == -1) continue;

                    driverService.AssignDriver(availableForAssigneDrivers[assigneDriverChoise - 1], availableForAssigneCars[assigneCarChoise - 1]);
                }
                else if (driverChoice == 2)
                {
                    List<Driver> availableForUnAssigneDrivers = availableDriver.Where(x=>x.Car != null).ToList();

                    int unAssigneDriverChoise = uiService.ChooseEntitiesMenu(availableForUnAssigneDrivers);
                    if (unAssigneDriverChoise == -1) continue;

                    driverService.UnassignDriver(availableForUnAssigneDrivers[unAssigneDriverChoise - 1]);
                }
                break;
            case MenuChoice.ChangePassword:
                string oldPassword = ExtendedConsole.GetInput("Please enter old password:");
                string newPassword = ExtendedConsole.GetInput("Please enter new password:");
                bool changePasswordSucc = userService.ChangePassword(oldPassword, newPassword);
                if (changePasswordSucc) ExtendedConsole.WriteLine("Password Changed", ConsoleColor.DarkGreen);
                 else ExtendedConsole.WriteLine("Password Change failed. Please try again.", ConsoleColor.Red);
                Console.ReadLine();
                break;
            case MenuChoice.Exit:
                userService.CurrentUser = null;
                break;
           }
        #endregion
}


#region Seed
void InitializeStartingData()
{
    User administrator = new User("BobBobsky", "bobbest1", Role.Admin);
    User manager = new User("JillWayne", "jillawesome1", Role.Manager);
    User maintenances = new User("GregGregsky", "supergreg1", Role.Maintenance);
    User maintenances1 = new User("test123", "test123", Role.Manager);
    List<User> seedUsers = new List<User>() { administrator, manager, maintenances, maintenances1 };
    userService.Seed(seedUsers);

    Car car1 = new Car("Auris (Toyota)", "AFW950", new DateTime(2025, 12, 1));
    Car car2 = new Car("Auris (Toyota)", "CKE480", new DateTime(2021, 10, 15));
    Car car3 = new Car("Transporter (Volkswagen)", "GZDR69", new DateTime(2024, 5, 30));
    Car car4 = new Car("Mondeo (Ford)", "5RIP283", new DateTime(2022, 5, 13));
    Car car5 = new Car("Premier (Peugeot)", "2AR9907", new DateTime(2022, 11, 9));
    Car car6 = new Car("Vito (Mercedes)", "6RND294", new DateTime(2025, 3, 11));
    Car car7 = new Car("Vito (Mercedes)", "6RND295", new DateTime(2025, 8, 11));
    List<Car> seedCars = new List<Car>() { car1, car2, car3, car4, car5, car6 };
    carService.Seed(seedCars);

    Driver driver1 = new Driver("Romario", "Walsh", Shift.NoShift, null, "LC12456123", new DateTime(2025, 11, 11));
    Driver driver2 = new Driver("Kathleen", "Rankin", Shift.Morning, car1, "LC54435234", new DateTime(2022, 1, 12));
    Driver driver3 = new Driver("Ashanti", "Mooney", Shift.Night, car1, "LC65803245", new DateTime(2022, 5, 19));
    Driver driver4 = new Driver("Zakk", "Hook", Shift.Afternoon, car1, "LC20897583", new DateTime(2023, 9, 28));
    Driver driver5 = new Driver("Xavier", "Kelly", Shift.NoShift, null, "LC15636280", new DateTime(2024, 6, 1));
    Driver driver6 = new Driver("Joy", "Shelton", Shift.Night, car2, "LC47845611", new DateTime(2023, 7, 3));
    Driver driver7 = new Driver("Kristy", "Riddle", Shift.Morning, car3, "LC19006543", new DateTime(2024, 6, 12));
    Driver driver8 = new Driver("Stuart", "Mayer", Shift.Night, car3, "LC53187767", new DateTime(2023, 10, 10));
    List<Driver> seedDrivers = new List<Driver>() { driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8 };
    driverService.Seed(seedDrivers);
}

#endregion

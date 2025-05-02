using StaticClasses;
using StaticClasses.Entities.Helpers;
using StaticClasses.Entities.Models;
/*
    STATIC CLASS:
        - Cannot be instantiated (no objects)
        - Contains only static members (fields, methods, properties)
        - Is loaded once in memory and shared
    USE CASES:
        - Utility/helper methods (e.g., StringHelper, ListHelper)
        - Application-level constants or configuration
        - In-memory fake databases (like StaticDb, OrdersTempDB..)
*/

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("===== Order Management App =====");
//Console.ResetColor();

// NOTE: Cannot create an instance from *static* class
//ConsoleHelper consoleHelper = new ConsoleHelper(); 
//consoleHelper.WriteInColor("===== Order Management App =====", ConsoleColor.Cyan);

bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    ConsoleHelper.WriteInColor("===== Order Management App =====", ConsoleColor.Cyan);

    //Console.WriteLine(OrdersStaticDB.Users.Count);
    //Console.WriteLine(OrdersStaticDB.Users.Count);
    //Console.WriteLine(OrdersStaticDB.Users.Count);
    //Console.WriteLine(OrdersStaticDB.Users.Count);

    Console.WriteLine("\nPlease choose an option:");
    Console.WriteLine("1) List all users");
    Console.WriteLine("2) Add new order to user");
    Console.WriteLine("3) Exit");

    string input = Console.ReadLine();
    int option = ValidationHelper.ValidateNumberInput(input);

    if (option == -1)
    {
        ConsoleHelper.WriteInColor("Invalid option. Try again!", ConsoleColor.Red);
        Console.ReadLine();
        continue;
    }

    switch (option)
    {
        case 1:
            ConsoleHelper.WriteInColor("\nList of Users:", ConsoleColor.Magenta);
            OrdersStaticDB.ListUsers();
            break;
        case 2:
            ConsoleHelper.WriteInColor("\nEnter User Id", ConsoleColor.Magenta);
            int userId = Convert.ToInt32(Console.ReadLine());

            ConsoleHelper.WriteInColor("\nEnter Order Title", ConsoleColor.Magenta);
            string title = Console.ReadLine();

            ConsoleHelper.WriteInColor("\nEnter Order Description", ConsoleColor.Magenta);
            string description = Console.ReadLine();

            Order newOrder = new Order(0, title, description);
            OrdersStaticDB.InsertOrder(userId, newOrder);
            break;
        case 3:
            ConsoleHelper.WriteInColor("Exiting the program. Goodbye!", ConsoleColor.DarkCyan);
            isRunning = false;
            break;
        default:
            break;
    }

    Console.ReadLine();
}
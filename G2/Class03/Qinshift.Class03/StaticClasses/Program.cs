using StaticClasses;
using StaticClasses.Entities.Helpers;
using StaticClasses.Entities.Models;

//Console.ForegroundColor = ConsoleColor.DarkCyan;
//Console.WriteLine("=== Welcome to Order Managment App ===");
//Console.ResetColor();

// Cannot create an instance from *static* class
//ConsoleHelper consoleHelper = new ConsoleHelper();
//consoleHelper.WriteInColor("");

bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    ConsoleHelper.WriteInColor("=== Welcome to Order Managment App ===", ConsoleColor.DarkCyan);

    Console.WriteLine("\nPlease choose an option:");
    Console.WriteLine("1) List all users");
    Console.WriteLine("2) Add new order to user");
    Console.WriteLine("3) Show order status messages");
    Console.WriteLine("4) Exit");

    bool isValid = int.TryParse(Console.ReadLine(), out int input);

    switch (input)
    {
        case 1:
            ConsoleHelper.WriteInColor("\nList of Users:", ConsoleColor.Magenta);
            OrdersTempDB.ListUsers();
            OrdersTempDB.ListUsers();
            break;
        case 2:
            ConsoleHelper.WriteInColor("\nEnter User Id:", ConsoleColor.Yellow);
            int userId = Convert.ToInt32(Console.ReadLine());

            ConsoleHelper.WriteInColor("\nEnter Order Title:", ConsoleColor.Yellow);
            string title = Console.ReadLine();

            ConsoleHelper.WriteInColor("\nEnter Order Description:", ConsoleColor.Yellow);
            string description = Console.ReadLine();

            Order newOrder = new Order(0, title, description);
            OrdersTempDB.InsertOrder(userId, newOrder);
            break;
        case 3:
            ConsoleHelper.WriteInColor("\nOrder Status Messages:\n", ConsoleColor.Cyan);
            foreach (Order order in OrdersTempDB.Orders)
            {
                ConsoleHelper.WriteInColor($"{order.Title} - ", ConsoleColor.White);
                TextHelper.GenerateStatusMessage(order.Status);
            }
            break;
        case 4:
            isRunning = false;
            ConsoleHelper.WriteInColor("Exiting the program. Goodbye!", ConsoleColor.DarkCyan);
            break;
        default:
            ConsoleHelper.WriteInColor("Invalid option", ConsoleColor.Red);
            break;
    }
    

    Console.ReadLine();
}
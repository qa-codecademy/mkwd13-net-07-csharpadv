using StaticClasses.Entities.Enums;
using StaticClasses.Entities.Helpers;
using StaticClasses.Entities.Models;

namespace StaticClasses
{
    public static class OrdersStaticDB
    {
        private static int orderIdCounter = 5;
        public static List<User> Users = new List<User>();
        public static List<Order> Orders = new List<Order>();

        // Won't work !!!
        //public OrdersStaticDB()   
        //{

        //}

        // NOTE: Static classes can have only static constructor
        // It will only execute once, the first time this class is used, when the app is started
        // Static constructor does not have access modifier
        static OrdersStaticDB()
        {
            ConsoleHelper.WriteInColor("Hello from OrdersStaticDB static constructor !", ConsoleColor.Yellow);
            Users = new List<User>()
            {
                new User(1, "Bob123", "Bob St."),
                new User(2, "Jill123", "Jill St."),
            };

            Orders = new List<Order>()
            {
                new Order(1, "book of books", "Best book ever", OrderStatus.Delivered),
                new Order(2, "keyboard", "Mechanical", OrderStatus.InProgress),
                new Order(3, "Shoes", "Waterproof", OrderStatus.InProgress),
                new Order(4, "Set of Pens", "Ordinary pens", OrderStatus.Processing),
                new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatus.NotDelivered)
            };

            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);
        }

        public static void InsertOrder(int userId, Order order)
        {
            order.Id = ++orderIdCounter;
            Orders.Add(order);
            Users.First(u => u.Id == userId).Orders.Add(order);

            ConsoleHelper.WriteInColor($"Order successfully created! Order Id: {order.Id}", ConsoleColor.Green);
            ConsoleHelper.WriteInColor($"Total number of orders in the system: {Orders.Count}", ConsoleColor.Blue);
        }

        public static void ListUsers()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Users[i].Username} has {Users[i].Orders.Count} orders.");
            }
        }
    }
}

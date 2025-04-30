using StaticClasses.Entities.Enums;
using StaticClasses.Entities.Helpers;
using StaticClasses.Entities.Models;

namespace StaticClasses
{
    public static class OrdersStaticDB
    {
        private static int orderIdCounter;
        public static List<User> Users = new List<User>();
        public static List<Order> Orders = new List<Order>();

        //public OrdersStaticDB()   
        //{
            
        //}

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
    }
}

using StaticClasses.Domain.Enums;
using StaticClasses.Domain.Models;

namespace StaticClasses.Domain
{
    //This static class simulates Database
    //It is alive during the lifecycle of the app
    //can be accessed from anywhere
    public static class OrdersDb
    {
        //these lists simulate a real db
        //all members need to be static
        public static List<Order> Orders { get; set; }
        public static List<User> Users { get; set; }

        public static int lastOrderId = 5;

        //all members need to be static
        static OrdersDb() {

            Orders = new List<Order>()
            {
                new Order(1, "book of books", "Best book ever", OrderStatusEnum.Delivered),
                new Order(2, "keyboard", "Mechanical", OrderStatusEnum.DeliveryInProcess),
                new Order(3, "shoes", "Waterproof", OrderStatusEnum.DeliveryInProcess),
                new Order(4, "sets of pens", "ordinary blue pens", OrderStatusEnum.Processing),
                new Order(5, "sticky notes", "yellow", OrderStatusEnum.Problem)
            };

            Users = new List<User>()
            {
                new User (1,"PetkoP", "Address1"),
                new User(2, "StefanS", "Address2")
            };

            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);
        }

        public static void PrintUsers()
        {
            int i = 1;
            foreach(User user in Users)
            {
                Console.WriteLine($"({i}) {user.Username}");
                i++;
            }
        }

        public static void InsertOrder(int userId, Order order)
        {
            //simulate that the db generates the id, it should be +1 from the last order
            lastOrderId++; //lastOrderId = lastOrderId + 1;
            order.Id = lastOrderId;

            //add the order to the lust of order (the table Order in our simulated db)
            Orders.Add(order);

            //add the order to the user

            //validate that user with userId exists
            User userFromDb = Users.FirstOrDefault(x => x.Id == userId);
            if (userFromDb != null)
            {
                userFromDb.Orders.Add(order);
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }
    }
}

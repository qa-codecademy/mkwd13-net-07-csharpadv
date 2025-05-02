using StaticClasses.Domain.Enums;

namespace StaticClasses.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatusEnum Status { get; set; }

        public Order() {
            Id = new Random().Next(1, 100000);
            Status = OrderStatusEnum.Created;
        }

        public Order(int id, string title, string description, OrderStatusEnum statusEnum)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = statusEnum;
        }

        //in a standard class we can have non-static methods (members)
        public void PrintTitle()
        {
            Console.WriteLine(Title);
        }

        //in a non-static class we can have static methods (members)
        public static bool IsValid(Order order)
        {
            return order.Id > 0 && !string.IsNullOrEmpty(order.Title) && !string.IsNullOrEmpty(order.Description);
        }
    }
}

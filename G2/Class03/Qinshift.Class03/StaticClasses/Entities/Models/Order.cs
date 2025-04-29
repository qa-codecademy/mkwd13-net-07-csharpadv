using StaticClasses.Entities.Enums;

namespace StaticClasses.Entities.Models
{
    public class Order : BaseEntity
    {
        //public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int id, string title, string description, OrderStatus status) : base(id)
        {
            Title = title;
            Description = description;
            Status = status;
        }

        public string GetOrderInfo()
        {
            return $"{Title} - {Description}";
        }
    }
}

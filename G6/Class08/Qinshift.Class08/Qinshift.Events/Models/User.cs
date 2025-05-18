using Qinshift.Events.Enums;

namespace Qinshift.Events.Models
{
    // Represents a SUBSCRIBER in the event system.
    // A user can subscribe to a market and receive promotions.
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public ProductType FavouriteProductType { get; set; }

        public User(int id, string name, string email, int age, ProductType favouriteProductType)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
            FavouriteProductType = favouriteProductType;
        }

        // This method is called when the user receives a promotion.
        // It prints the promotion details and checks if it matches the user's favorite product type.
        public void ReadPromotion(ProductType productType)
        {
            Console.WriteLine($"\nMr/Mrs: {Name}, the products of type {productType} are on sale !!!");
            if (productType == FavouriteProductType)
            {
                Console.WriteLine("MY FAVOURITE PRODUCTS YEEY!");
            }
        }
    }
}

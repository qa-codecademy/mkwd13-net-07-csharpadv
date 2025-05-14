using Events.Enums;
using Events.Models;

Console.WriteLine("\n============= SUPER MARKET =============\n");

// Create a new market instance
Market market = new Market
{
    Id = 1,
    Name = "Super Market",
    ProductType = ProductType.Electronics
};

// Create new user instances
User user1 = new User(1, "Bob Bobsky", "bob@mail.com", 32, ProductType.Electronics);
User user2 = new User(2, "John Doe", "john@mail.com", 23, ProductType.Food);
User user3 = new User(3, "Jane Doe", "jane@mail.com", 26, ProductType.Cosmetics);

// Subscribe user1 for promotion
market.SubscribeForPromotion(user1.ReadPromotion, user1.Email);
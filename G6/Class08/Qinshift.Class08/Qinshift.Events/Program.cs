using Qinshift.Events.Enums;
using Qinshift.Events.Models;

Console.WriteLine("\n============= SUPER MARKET =============\n");

// Create a new market instance
Market market = new Market
{
    Id = 1,
    Name = "Super Market",
    ProductTypeOnPromotion = ProductType.Electronics
};

// Create new user instances
User user1 = new User(1, "Bob Bobsky", "bob@mail.com", 34, ProductType.Electronics);
User user2 = new User(2, "John Doe", "john@mail.com", 23, ProductType.Food);
User user3 = new User(3, "Jane Doe", "jane@mail.com", 26, ProductType.Cosmetics);

// Subscribe user1 for promotion
market.SubscribeForPromotion(user1.ReadPromotion, user1.Email);
market.SubscribeForPromotion(user2.ReadPromotion, user2.Email);
market.SubscribeForPromotion(user3.ReadPromotion, user3.Email);

// Send promotions
market.SendPromotions();


Console.WriteLine("\n=======================================\n");


// Unsubscribe user1
market.UnsubscribeFromPromotions(user1.ReadPromotion, "I don't need your promotions anymore!");

market.ProductTypeOnPromotion = ProductType.Cosmetics;

// Send promotions (this time for Cosmetics)
market.SendPromotions();

Console.ReadLine();
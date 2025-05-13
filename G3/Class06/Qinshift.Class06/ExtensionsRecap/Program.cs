// See https://aka.ms/new-console-template for more information
using ExtensionsRecap;

Console.WriteLine("Hello, World!");

Product prod1 = new Product
{
    Id = 1,
    Name = "Prod 1",
    Price = 234.34
};

Product prod2 = new Product
{
    Id = 2,
    Name = "Prod 2",
    Price = 3243
};

Product prod3 = new Product
{
    Id = 3,
    Name = "Prod 3",
    Price = 324_343
};

double prod1TotalPrice = ProductExtensions.GetTotalPrice(prod1, 10, false);
Console.WriteLine($"Prod1 Total Price: {prod1TotalPrice}");

Console.WriteLine($"Prod2 Total Price: {prod2.GetTotalPrice(100, true)}");
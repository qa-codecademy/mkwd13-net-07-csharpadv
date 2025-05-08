using ExtensionMethods.Models;

namespace ExtensionMethods.Helpers
{
    // We can create extension methods on any type of entities
    public static class ProductExtensions
    {
        public static void PrintInfo(this List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.GetInfo());
            }
        }
    }
}

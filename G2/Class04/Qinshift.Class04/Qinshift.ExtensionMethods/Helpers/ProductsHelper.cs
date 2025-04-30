using Qinshift.ExtensionMethods.Entities;

namespace Qinshift.ExtensionMethods.Helpers
{
    public static class ProductsHelper
    {
        public static void PrintProductId(this Product product)
        {
            Console.WriteLine(product.Id);
        }
    }
}

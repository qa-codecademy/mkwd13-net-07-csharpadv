using Qinshift.ExtensionMethods.Entities;

namespace Qinshift.ExtensionMethods.PiggybackingHelpers
{
    public static class PiggybackingProductsHelper
    {
        public static void PiggybackingPrintProductId(this Product product)
        {
            Console.WriteLine(product.Id);
        }
    }
}

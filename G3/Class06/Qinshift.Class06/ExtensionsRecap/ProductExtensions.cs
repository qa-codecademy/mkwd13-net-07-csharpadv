namespace ExtensionsRecap
{
    public static class ProductExtensions
    {
        public static double GetTotalPrice(this Product product, int quantity, bool isOnPromotion)
        {
            if (isOnPromotion)
            {
                return product.Price * quantity - 100;        
            }
            return product.Price * quantity;        
        }
    }
}

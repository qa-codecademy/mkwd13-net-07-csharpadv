using Events.Enums;

namespace Events.Models
{
    // Represents a PUBLISHER in the event system.
    // The Market can send promotions to all subscribed users.
    public class Market
    {
        // ===> Delegate
        // Defines the method signature required for subscribing to the Promotions event.
        public delegate void PromotionHandler(ProductType productType);

        // ===> Event
        // Keeps a list of subscribed methods to be called when promotions are sent.
        private event PromotionHandler OnPromotionSent;

        public int Id { get; set; }
        public string Name { get; set; }
        // The type of product this market promotes.
        public ProductType ProductType { get; set; }
        // Stores the email addresses of subscribers.
        public List<string> SubscribersEmails { get; set; } = new List<string>();

        public Market()
        {
            
        }

        // Subscribes a user to promotions.
        // Adds the provided method to the Promotions event and stores the user's email.
        public void SubscribeForPromotion(PromotionHandler promotionHandler, string email)
        {
            OnPromotionSent += promotionHandler;
            SubscribersEmails.Add(email);
        }


    }
}

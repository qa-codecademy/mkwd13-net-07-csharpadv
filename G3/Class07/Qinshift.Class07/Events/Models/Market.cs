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
        public List<string> Complaints { get; set; } = new List<string>();

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

        // Sends out promotions to all subscribers.
        // Thread.Sleep(3000) simulates that something is being done for 3 seconds
        public void SendPromotions()
        {
            Console.WriteLine("==================");
            Console.WriteLine($"{Name} is sending promotions for {ProductType}");
            Console.WriteLine("... Sending ...");
            Thread.Sleep(3000);
            // NotifySubscribers() is executed after 3 seconds
            NotifySubscribers();
        }

        // This method triggers (raises) the Promotions event
        // It notifies all subscribers (methods that previously subscribed to the event) 
        // and passes the current ProductType as a parameter to them
        // Each subscriber method will receive this ProductType and can react accordingly
        private void NotifySubscribers()
        {
            OnPromotionSent(ProductType);
        }

        // Unsubscribes a user from promotions.
        // Removes the provided method from the Promotions event and stores the user's reason.
        public void UnsubscribeFromPromotions(PromotionHandler promotionHandler, string reason)
        {
            OnPromotionSent -= promotionHandler;
            Complaints.Add(reason);
        }

        public void ReadComplaints()
        {
            Console.WriteLine($"{Name} Complaints:");
            foreach (string complaint in Complaints)
            {
                Console.WriteLine(complaint);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.OopAdv.Class15.Principles
{
    //BAD EXAMPLE
    public class NotificationService()
    {
        public void SendNotification(string message, string type)
        {
            if (type == "sms")
            {
                Console.WriteLine("Sending sms notification....");
            }
            else if (type == "push")
            {
                Console.WriteLine("Sending push notification....");
            }
            else if (type == "email")
            {
                //code.... for sending email
            }
        }
    }
    // GOOD EXAMPLE
    public interface INotificationSender
    {
        void SendNotification(string message);
    }
    public class EmailSender() : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending email notification....");
        }
    }

    public class PushSender() : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending push notification....");
        }
    }
    public class NotificationServiceGood
    {
        private readonly INotificationSender _sender;
        public NotificationServiceGood(INotificationSender sender)
        {
            _sender = sender;
        }
        public void Notify(string message) 
        { 
            _sender.SendNotification(message);
        }
    }
}

namespace Qinshift.Principles.SOLID
{
    /*
        *** DEPENDENCY INVERSION PRINCIPLE ***
     
        => Write *DECOUPLED* code whenever possible
            *DECOUPLED* means that we don't want our code to be full of dependencies, we don't want all pieces of code to be dependent on one another. If we have tightly coupled code ( code full of dependencies ) and we try to change something we would quickly realize that we need to change a lot of code for that small change.
                
        => Abstract the dependencies that we have and ask for them from outside
     */

    #region Without DIP
    // Bad Example
    public class EmailMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            // ... Code that sends an Email
        }
    }

    public class SmsMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            // ... Code that sends an SMS
        }
    }

    public class FacebookMessage
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }
        public void SendFacebook()
        {
            // ... Code that sends a Facebook Message
        }
    }

    public class NotificationWithoutDIP
    {
        private EmailMessage _email;
        private SmsMessage _sms;
        private FacebookMessage _facebook;

        public NotificationWithoutDIP()
        {
            _email = new EmailMessage();
            _sms = new SmsMessage();
            _facebook = new FacebookMessage();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
            _facebook.SendFacebook();
        }
    }

    #endregion


    #region With DIP
    // Good Example
    public interface IMessage
    {
        void SendMessage();
    }

    public class Email : IMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            // ... Code that sends an Email
        }
    }

    public class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            // ... Code that sends an SMS
        }
    }

    public class Facebook : IMessage
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            // ... Code that sends a Facebook Message
        }
    }

    public class NotificationWithDIP
    {
        private ICollection<IMessage> _messages;

        public NotificationWithDIP(ICollection<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
    #endregion
}

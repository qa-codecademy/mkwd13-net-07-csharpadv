using StaticClasses.Entities.Enums;

namespace StaticClasses.Entities.Helpers
{
    public static class TextHelper
    {
        public static int MessagesGenerated = 0;

        public static void GenerateStatusMessage(OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.Processing:
                    ConsoleHelper.WriteInColor("[Processing] The order is being processed.", ConsoleColor.Blue);
                    break;
                case OrderStatus.Delivered:
                    ConsoleHelper.WriteInColor("[Delivered] The order is successfully delivered.", ConsoleColor.Green);
                    break;
                case OrderStatus.DeliveryInProgress:
                    ConsoleHelper.WriteInColor("[InProgress] The delivery is in progress.", ConsoleColor.Yellow);
                    break;
                case OrderStatus.NotDelivered:
                    ConsoleHelper.WriteInColor("[Not Delivered] There was a problem with the delivery.", ConsoleColor.Red);
                    break;
            }
            MessagesGenerated++;
        }

        public static string CapitalizeFirstLetter(string word)
        {
            if (word.Length == 1)
            {
                return word.ToUpper();
            }

            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}

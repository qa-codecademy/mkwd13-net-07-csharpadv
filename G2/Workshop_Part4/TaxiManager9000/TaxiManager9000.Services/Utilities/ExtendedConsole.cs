namespace TaxiManager9000.Services.Utilities
{
    public static class ExtendedConsole
    {
        public static void WriteLine(string value, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        public static void Write(string value, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ResetColor();
        }

        public static string GetInput(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public static void Separator() => Console.WriteLine("-------------------------");

        public static void NoItemsMessage<T>() => Console.WriteLine($"No {typeof(T).Name}s available.");
    }
}

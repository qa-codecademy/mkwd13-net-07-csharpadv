namespace TaxiManager9000.Helpers
{
    public static class ExtendedConsole
    {
        public static void PrintInColor(string? value, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        public static void PrintTitle(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.ReadLine();
        }

        public static string? GetInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        public static void NoItemsMessage<T>() => Console.WriteLine($"No {typeof(T).Name}s available");

        public static void Separator() => Console.WriteLine("---------------------------");
    }
}

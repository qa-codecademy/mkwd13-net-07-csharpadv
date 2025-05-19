namespace Qinshift.Helpers
{
    public static class ConsoleHelper
    {
        public static void WriteInColor(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}

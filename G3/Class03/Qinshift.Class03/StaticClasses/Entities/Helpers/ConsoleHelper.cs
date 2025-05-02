namespace StaticClasses.Entities.Helpers
{
    public static class ConsoleHelper
    {
        public static void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        //public void PrintSomething()
        //{
        //    Console.WriteLine("Something");
        //}
    }
}

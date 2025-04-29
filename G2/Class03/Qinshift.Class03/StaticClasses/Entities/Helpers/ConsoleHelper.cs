namespace StaticClasses.Entities.Helpers
{
    /*
         STATIC CLASS:
            - Cannot be instantiated (no objects)
            - Contains only static members (fields, methods, properties)
            - Is loaded once in memory and shared
         USE CASES:
            - Utility/helper methods (e.g., StringHelper, ListHelper)
            - Application-level constants or configuration
            - In-memory fake databases (like StaticDb, OrdersTempDB..)
    */
    public static class ConsoleHelper
    {
        public static void WriteInColor(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        // NOTE: Every member inside a static class MUST BE STATIC
        //public void DoSomething()
        //{

        //}
    }
}

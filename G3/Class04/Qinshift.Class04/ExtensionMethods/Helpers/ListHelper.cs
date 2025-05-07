namespace ExtensionMethods.Helpers
{
    public static class ListHelper
    {
        public static void PrintStrings(this List<string> strings)
        {
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public static void Print<T>(this List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

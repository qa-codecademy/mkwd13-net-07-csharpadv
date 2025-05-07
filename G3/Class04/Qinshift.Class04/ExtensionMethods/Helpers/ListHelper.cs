namespace ExtensionMethods.Helpers
{
    public static class ListHelper
    {
        /// <summary>
        ///     Extension method for printing List of strings
        /// </summary>
        public static void PrintStrings(this List<string> strings)
        {
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// A Generic extension method that can be called on any list with items and print the list
        /// </summary>
        public static void Print<T>(this List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

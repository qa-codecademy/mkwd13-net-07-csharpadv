namespace Generics
{
    public static class GenericHelper<T>
    {
        public static void PrintList(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintListInfo(List<T> items)
        {
            Console.WriteLine($"The list has {items.Count} items. They are of type {items.FirstOrDefault()?.GetType().Name}");
        }

        //if we want to use multiple generics we need to specify them after the name of the method
        public static void Test<T1, T2, R>(T1 firstParam, T2 secondParam, List<R> list)
        {
            Console.WriteLine("Multiple types");
        }
    }
}

namespace Generics.Helpers
{
    /// <summary>
    ///     Class with generic methods.
    ///     Generic Methods allow you to write methods that can operate on any data type.
    /// </summary>
    public class GenericListHelper
    {
        // SYNTAX: [access modifier] [return type] [method name]<T> ([parameters])
        public void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        // Works as well with static members
        public static void PrintInfo<T>(List<T> list)
        {
            T first = list.First();
            Console.WriteLine($"This list has {list.Count} elements and is of type {first.GetType().Name}!");
            // Console.WriteLine($"This list has {list.Count} elements and is of type {typeof(T).Name}!"); // can use typeof(T) as well
        }
    }
}

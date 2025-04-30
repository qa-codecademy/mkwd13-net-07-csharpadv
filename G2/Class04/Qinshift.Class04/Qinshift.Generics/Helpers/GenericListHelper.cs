
namespace Qinshift.Generics.Helpers
{
    public class GenericListHelper<T>
    {
        public static void GoThroughItems(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item);
            }
        }

        public static void GetInfoForItems(List<T> items)
        {
            T first = items.First();
            Console.WriteLine($"This list has {items.Count} items and is of type {first.GetType().Name}!");
        }

    }
}

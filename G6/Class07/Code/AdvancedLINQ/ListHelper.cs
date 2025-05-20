using AdvancedLINQ.Domain.Models;
using System.Data;

namespace AdvancedLINQ
{
    public static class ListHelper
    {
        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine($"Printing {list.Count} items:");
            foreach( T item in list )
            {
                Console.WriteLine( item );
            }
        }

        public static void PrintEntities<T>(this List<T> list) where T : BaseEntity
        {
            Console.WriteLine($"Printing {list.Count} items:");
            foreach (T item in list)
            {
                item.PrintInfo();
            }
        }
    }
}

using Qinshift.Class06.LinqMethods.Entities;


namespace Qinshift.Class06.LinqMethods.Helpers
{
    public static class ListHelper
	{
		public static void PrintSimple<T>(this List<T> list)
		{
			Console.WriteLine("Printing...");
			Console.WriteLine("------------------------------");
			foreach (T item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("------------------------------");
		}

		public static void PrintEntities<T>(this List<T> list) where T : BaseEntity
		{
			Console.WriteLine($"Printing {list[0].GetType().Name}s...");
			Console.WriteLine("------------------------------");
			foreach (T item in list)
			{
				Console.WriteLine(item.Info());
			}
			Console.WriteLine("------------------------------");
		}
	}
}

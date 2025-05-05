namespace Generics.Helpers
{
    /// <summary>
    ///     Class with non-generic methods. You need to repeat the same logic for different type of data.
    /// </summary>
    public class NotGenericListHelper
    {
        public void PrintStrings(List<string> strings)
        {
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForStrings(List<string> strings)
        {
            string first = strings.First();
            Console.WriteLine($"This list has {strings.Count} elements and is of type {first.GetType().Name}!");
        }

        public void PrintIntegers(List<int> integers)
        {
            foreach (int item in integers)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForIntegers(List<int> integers)
        {
            int first = integers.First();
            Console.WriteLine($"This list has {integers.Count} elements and is of type {first.GetType().Name}!");
        }

        public void PrintBooleans(List<bool> booleans)
        {
            foreach (bool item in booleans)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForBooleans(List<bool> booleans)
        {
            bool first = booleans.First();
            Console.WriteLine($"This list has {booleans.Count} elements and is of type {first.GetType().Name}!");
        }

    }
}

namespace Qinshift.Generics.Helpers
{
    public class NotGenericHelper
    {
        public void GoThroughStrings(List<string> strings)
        {
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }

        public void GetInfoForStrings(List<string> strings)
        { 
            string first = strings.First();
            Console.WriteLine($"This list has {strings.Count} items and is of type {first.GetType().Name}!");
        }

        public void GoTroughInts(List<int> ints)
        {
            foreach(int num in ints)
            {
                Console.WriteLine(num);
            }
        }

        public void GetInfoForInts(List<int> ints)
        {
            int first = ints.First();
            Console.WriteLine($"This list has {ints.Count} items and is of type {first.GetType().Name}!");
        }

    }
}

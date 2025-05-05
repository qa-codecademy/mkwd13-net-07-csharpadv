namespace Generics
{
    public class NonGenericHelper
    {
        public void PrintListOfStrings(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintListofInts(List<int> ints)
        {
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintListofBools(List<bool> bools)
        {
            foreach (bool b in bools)
            {
                Console.WriteLine(b);
            }
        }

        public void PrintInfoForStringList(List<string> strings)
        {
            //the ? checks if it is null, only if it is not null it will call the GetType => this way we escape the posibility for an exception
            Console.WriteLine($"The list has {strings.Count} members. They are of type {strings.FirstOrDefault()?.GetType().Name}");
        }

        int a = 5; //non-nullable - it does not allow null value
        int? b = 5; //nullable  - it allows null value   
        
        public void PrintInfoForIntsList(List<int> ints)
        {
            Console.WriteLine($"The list has {ints.Count} members. They are of type {ints.FirstOrDefault().GetType().Name}");
        }
    }
}

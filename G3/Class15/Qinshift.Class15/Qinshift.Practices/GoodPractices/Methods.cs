namespace Qinshift.Practices.GoodPractices
{
    /*
        *** METHODS GOOD PRACTICES ***

        1. Keep methods short, focused on doing ONE thing
        2. Avoid too many parameters (If it has many parameters, consider introducing some class/object as a parameter, containing all the needed information)
        3. If a method has too many lines of code, think about splitting it into multiple smaller methods if possible (create private methods that complement the main method)
        4. Write decoupled methods (methods that don't rely on other methods or on global variables) *when possible*
        5. The core idea of methods is to be REUSABLE
     */

    #region Bad Example
    // Bad Example
    internal class NumberServiceBad
    {
        public List<int> numbers = new List<int>();
        public void GetStats()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("You entered: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Stats:");
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"Even numbers: {even}");

            int odd = numbers.Count - even;
            Console.WriteLine($"Odd numbers: {odd}");

            int positive = numbers.Where(x => x >= 0).Count();
            Console.WriteLine($"Positive numbers: {positive}");

            int negative = numbers.Count - positive;
            Console.WriteLine($"Negative numbers: {negative}");

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
    #endregion

    #region Good Example

    // Good Example
    internal class NumberService
    {
        public List<int> RequestNumbers(int numbersCount)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbersCount; i++)
            {
                Console.Write("Enter number:");
                result.Add(int.Parse(Console.ReadLine()));
            }
            return result;
        }

        public void PrintNumbersInOneLine(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void PrintStats(List<int> numbers)
        {
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"Even numbers: {even}");

            int odd = numbers.Count - even;
            Console.WriteLine($"Odd numbers: {odd}");

            int positive = numbers.Where(x => x >= 0).Count();
            Console.WriteLine($"Positive numbers: {positive}");

            int negative = numbers.Count - positive;
            Console.WriteLine($"Negative numbers: {negative}");

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }

    #endregion
}

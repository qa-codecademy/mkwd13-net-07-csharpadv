namespace Delegates
{
    internal class Program
    {
        // ===> Delegate is like a type of a method — it lets you store a method, with the specified parameters and return, inside a variable

        // Delegate type that takes 1 string and returns nothing (void)
        private delegate void SayDelegate(string something);
        // Delegate type that takes 2 integers and returns an integer
        private delegate int NumberDelegate(int num1, int num2);

        private delegate string ProductInfoDelegate(Product product);

        private static void SayHello(string name)
        {
            Console.WriteLine($"SayHello {name}");
        }

        private static void SayWhatever(string whatever, SayDelegate sayDelegate)
        {
            sayDelegate(whatever);
        }

        private static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SayDelegate sayHello = new SayDelegate(word => Console.WriteLine($"Hello {word}"));
            sayHello("Delegates");

            SayDelegate say = new SayDelegate(SayHello);
            say("Bob");

            SayWhatever("WHATEVER", sayHello);
            SayWhatever("WHATEVER", SayHello);

            NumberDelegate sum = new NumberDelegate((num1, num2) => num1 + num2);
            Console.WriteLine($"Sum of 2 + 34 = {sum(2, 34)}");

            NumberDelegate subtract = new NumberDelegate(Subtract);
            Console.WriteLine($"Result of 34 - 3 = {subtract(34, 3)}");
        }
    }

    internal class Product
    {
    }
}

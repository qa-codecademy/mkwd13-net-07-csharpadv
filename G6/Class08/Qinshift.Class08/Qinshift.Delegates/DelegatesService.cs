namespace Qinshift.Delegates
{
    public class DelegatesService
    {
        // ===> Delegate is like a type of a method — it lets you store a method, with the specified parameters and return, inside a variable

        // Delegate type that takes 1 string and returns nothing (void)
        // Action<string> => if we use the pre-defined Action delegate
        private delegate void SayDelegate(string something);
        // Delegate type that takes 2 integers and returns an integer
        private delegate int NumberDelegate(int num1, int num2);
        // Delegate type that takes 1 Product Object and returns a string
        private delegate string ProductInfoDelegate(Product product);

        private void SayHello(string someString)
        {
            Console.WriteLine("HELLOOOOOO!");
        }

        // Here we are expecting a parameter of type SayDelegate, which means that we are actually expecting method (that is void and has 1 string parameter) as the second argument when executing SayWhatever method
        private void SayWhatever(string whatever, SayDelegate sayDelegate)
        {
            sayDelegate(whatever);
        }

        public void Main()
        {
            Console.WriteLine("Hello, World!");
            // ===== Recap Func & Action =====
            // In JavaScript:
            // let sum = (num1, num2) => num1 + num2;
            // sum(10,20) //30

            // In C#:
            Func<int, int, int> sum = (num1, num2) => num1 + num2;
            Action<string, int> printSomething = (word, num) => Console.WriteLine($"Word {word}. Number {num}...");
            Action<string> sayy = name => Console.WriteLine($"Hello {name}");

            Console.WriteLine("The sum result is " + sum(10, 20));
            printSomething("SOME WORD", 1324);

            // Using the SayDelegate method type to create method instances
            SayDelegate sayHello = new SayDelegate(word => Console.WriteLine($"Hello {word}"));
            sayHello("Bob Bobsky");

            SayDelegate sayHelloMethod = new SayDelegate(SayHello);
            sayHelloMethod("Bla bla");

            // Using the NumberDelegate method type
            NumberDelegate sumResult = new NumberDelegate((num1, num2) => num1 + num2);
            int result = sumResult(123, 100);
            Console.WriteLine(result); // 223

            // Sending method of type SayDelegate as an argument to other method
            SayWhatever("WHATEVER", (string word) => Console.WriteLine("Here is your word " + word));
            SayWhatever("WHATEVER", SayHello);

            Console.ReadLine();
        }
    }

    // Created for demo purposes...
    internal class Product
    {
    }
}

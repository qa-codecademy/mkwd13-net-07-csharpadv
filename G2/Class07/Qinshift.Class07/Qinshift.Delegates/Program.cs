
class Program
{
    static void SayHello(string person)
    {
        Console.WriteLine($"Hello there dear, {person}");
    }

    static void SayGoodBye(string person)
    {
        Console.WriteLine($"Goodbye {person}, see you next time!");
    }

    static void PrintNumber(int number)
    {
        Console.WriteLine(number);
    }

    static void SayWhatever(string whatever, SayDelegate sayDel)
    {
        Console.WriteLine("Chatbot says:");
        sayDel(whatever);
    }

    static void MasterCalculator(int a, int b, NumberDelegate numberDel)
    {
        Console.WriteLine($"The result is: {numberDel(a, b)}");
    }

    public delegate void SayDelegate(string person);
    public delegate int NumberDelegate(int a, int b);

    static void Main(string[] args)
    {
        #region Declare and Instantiate a delegate

        SayDelegate sayHelloDel = new SayDelegate(SayHello);
        SayDelegate sayGoodByeDel = new SayDelegate(SayGoodBye);
        SayDelegate sayWoowDel = new SayDelegate(x => Console.WriteLine($"Woooow {x}"));


        //SayDelegate printNumDel = new SayDelegate(PrintNumber);   ---> this will not work, because the signature of the PrintNumber method doesn't fit with the signature of the SayDelegate delegate

        sayHelloDel("Bob");
        sayGoodByeDel("Martin");
        sayWoowDel("Slave");


        #endregion

        #region Passing a method to a delegate parameter
        Console.WriteLine("======== Passing delegate as parameter on other method");
        SayWhatever("Bob", SayHello);
        SayWhatever("Jill", SayGoodBye);

        SayWhatever("Ana", x =>
        {
            Console.WriteLine($"Hi {x}, before the chat bot says somthing, welcome on behalf of our company!");
            SayHello(x);
        });

        #endregion

        #region Making a high order method
        MasterCalculator(123, 235, (a, b) => a + b);
        MasterCalculator(2356, 1289, (a, b) => a * b);
        MasterCalculator(478, 22, (a, b) => a - b);
        MasterCalculator(675, 25, (a, b) => a / b);
        MasterCalculator(2, 3, (a, b) => a * a + b * b);

        #endregion
    }
}
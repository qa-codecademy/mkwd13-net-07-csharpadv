
#region Delegates - Declare and Instantiating a delegate




#endregion


#region Passing a method to a delegate parameter




#endregion



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

    void SayWhatever(string whatever, SayDelegate sayDel)
    {

    }

    public delegate void SayDelegate(string person);

    static void Main(string[] args)
    {
        SayDelegate sayHelloDel = new SayDelegate(SayHello);
        SayDelegate sayGoodByeDel = new SayDelegate(SayGoodBye);
        SayDelegate sayWoowDel = new SayDelegate(x => Console.WriteLine($"Woooow {x}"));


        //SayDelegate printNumDel = new SayDelegate(PrintNumber);   ---> this will not work, because the signature of the PrintNumber method doesn't fit with the signature of the SayDelegate delegate

        sayHelloDel("Bob");
        sayGoodByeDel("Martin");
        sayWoowDel("Slave");
    }
}
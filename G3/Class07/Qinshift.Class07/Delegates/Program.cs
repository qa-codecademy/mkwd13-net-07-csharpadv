﻿namespace Delegates
{
    internal class Program
    {
        // ===> Delegate is like a type of a method — it lets you store a method, with the specified parameters and return, inside a variable

        // Delegate type that takes 1 string and returns nothing (void)
        private delegate void SayDelegate(string something);

        private static void SayHello(string name)
        {
            Console.WriteLine($"SayHello {name}");
        }

        private static void SayWhatever(string whatever, SayDelegate sayDelegate)
        {
            sayDelegate(whatever);
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
        }
    }
}

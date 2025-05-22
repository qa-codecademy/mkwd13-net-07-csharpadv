using Qinshift.Helpers;

namespace Qinshift.MemoryAllocation
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ExtendedConsole.PrintInColor($"User object {FirstName} created. [{DateTime.Now}]", ConsoleColor.Green);
        }

        // Class Finalizer (Destructor) => used to perform any necessary final clean-up when a class instance is being collected by the garbage collector
        // NOTE: This is only for DEMONSTRATION purposes, this process is automatically done. We don't need to create finalizers in any of the classes we create!
        ~User()
        {
            ExtendedConsole.PrintInColor($"User object {FirstName} destroyed. [{DateTime.Now}]", ConsoleColor.Red); // you'll probably need to wait for couple of minutes for this to be executed
        }

        public void PrintInto()
        {
            Console.WriteLine($"INFO: {FirstName} {LastName} ({Age})");
        }
    }
}

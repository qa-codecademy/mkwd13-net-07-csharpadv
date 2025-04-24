using AbstractAndInterface.Interfaces;

namespace AbstractAndInterface.Entities
{
    public abstract class Human : IHuman
    {
        public Human(string fullName, int age, long phoneNumber)
        {
            FullName = fullName;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public string FullName { get; set; }
        public int Age { get; set; }
        public long PhoneNumber { get; set; }

        public abstract string GetInfo();

        public void Greet(string name)
        {
            Console.WriteLine($"Hey there {name}! My name is {FullName}");
        }

        public string SayGoodbye(string name)
        {
            return $"Bye bye {name}";
        }
    }
}

using AbstractClassesAndInterfaces.Domain.Interfaces;

namespace AbstractClassesAndInterfaces.Domain.Models
{
    public abstract class Person : IPerson
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }

        public Person() { }

        //we don't use this constructor to create instances from Person, but we use it in the derived classes when we call the base constructor
        public Person(string fullName, int age, string address, long phoneNumber)
        {
            FullName = fullName;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FullName} {Age} : {PhoneNumber}");
        }

        //this method does not have an implementation in this (base) class. All classes that inherit from this class
        //MUST implement this method
        public abstract string GetProfessionalInfo();

        public void Greet()
        {
            Console.WriteLine($"Hello from {FullName}");
        }

        public void SendGift(string nameOfGift)
        {
            Console.WriteLine($"Sending {nameOfGift} from {Address}");
        }
    }
}

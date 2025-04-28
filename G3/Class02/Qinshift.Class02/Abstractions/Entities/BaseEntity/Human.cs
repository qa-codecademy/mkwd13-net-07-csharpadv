using Abstractions.Entities.Interfaces;

namespace Abstractions.Entities.BaseEntity
{
    /*
        *Abstract Class* => A class declared with the abstract keyword. It may contain abstract members, non-abstract members, constructors etc.

        *Abstract Member* => A member (method, property) declared in an abstract class without providing an implementation. Abstract members are intended to be implemented by derived classes.
        
        *Usecase* => Abstract classes are often used as base classes for inheritance. 
    */
    public abstract class Human : IHuman
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; }

        //public abstract string Test { get; set; } // abstract property (rarely used)

        public Human()
        {
            
        }

        public Human(int id, string firstName, string lastName, int age, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
        }

        // Abstract method => the derived classes will have to provide implementation
        public abstract string GetInfo();

        // Not abstract method => will be inherited as is
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void Greet(string name)
        {
            Console.WriteLine($"Hey there {name}. My name is {GetFullName()}.");
        }
    }
}

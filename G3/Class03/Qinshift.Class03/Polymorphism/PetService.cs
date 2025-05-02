using Polymorphism.Models;

namespace Polymorphism
{
    public class PetService
    {
        // Compile-Time Polymorphism ( Method overloading )
        // Both methods have the same name
        // Their signature is different

        // Method Signature: <method name>(<parameter types and order>)

        public void PrintPetInfo()
        {
            Console.WriteLine("Print some info...");
        }

        public void PrintPetInfo(Dog dog)
        {
            Console.WriteLine($"Dog {dog.Name} is {(dog.IsGoodBoi ? "good boy" : "NOT good boy")}");
        }

        public void PrintPetInfo(Dog dog, string owner)
        {
            Console.WriteLine($"Dog {dog.Name} is {(dog.IsGoodBoi ? "good boy" : "NOT good boy")}. Owner: {owner}");
        }

        public void PrintPetInfo(string owner, Dog dog)
        {
            Console.WriteLine($"Dog {dog.Name} is {(dog.IsGoodBoi ? "good boy" : "NOT good boy")}. Owner: {owner}");
        }
    }
}

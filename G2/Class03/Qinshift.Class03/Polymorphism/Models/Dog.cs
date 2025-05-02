namespace Polymorphism.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoy { get; set; }

        public override void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating. Nom Nom");
        }
    }
}

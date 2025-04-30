namespace Polymorphism.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }

        public override void Eat()
        {
            Console.WriteLine("The DOG is eating... NOM NOM NOM");
        }
    }
}

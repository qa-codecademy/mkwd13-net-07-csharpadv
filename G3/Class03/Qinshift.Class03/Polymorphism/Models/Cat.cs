namespace Polymorphism.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; } = true;

        public override void Eat()
        {
            Console.WriteLine("The CAT is eating... NOM NOM NOM");
        }
    }
}

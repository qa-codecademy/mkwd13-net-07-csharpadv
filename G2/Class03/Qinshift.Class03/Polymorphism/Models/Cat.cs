namespace Polymorphism.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }

        public override void Eat()
        {
            Console.WriteLine($"The cat is eating...mouse");
        }
    }
}

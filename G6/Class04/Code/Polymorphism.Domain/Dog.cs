namespace Polymorphism.Domain
{
    public class Dog : Pet
    {
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }

        //we use the override keyword to override the parent impl of a method
        public override void Eat()
        {
            //base.Eat();
            Console.WriteLine("Calling Eat method from Dog class");
        }
    }
}

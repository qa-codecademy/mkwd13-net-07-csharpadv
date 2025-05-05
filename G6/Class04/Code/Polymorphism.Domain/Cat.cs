namespace Polymorphism.Domain
{
    public class Cat : Pet
    {
        private int Age { get; set; }
        public override void Eat()
        {
           Console.WriteLine("Calling Eat method from Cat class");
        }

        public int GetAge()
        {
            Console.WriteLine("Getting the cat age...");
            return Age;
        }

        public void SetAge(int age)
        {
            Console.WriteLine("Setting the age..");
            Age = age;
        }
    }
}

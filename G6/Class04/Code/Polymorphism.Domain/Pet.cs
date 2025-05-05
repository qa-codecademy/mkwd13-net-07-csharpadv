namespace Polymorphism.Domain
{
    public class Pet
    {
        public string Name
        {
            get
            {
                Console.WriteLine("Getting the name");
                return Name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Name = value;
                }
            }
        }

        //we use the virtual keyword, to allow the method to be overriden in the derived classes
        public virtual void Eat()
        {
            Console.WriteLine("Calling Eat method from Pet class...");
        }
    }
}

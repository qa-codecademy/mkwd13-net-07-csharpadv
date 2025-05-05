namespace Polymorphism.Domain.Service
{
    //Compile time polymorphism
    //Having methods with the same name
    //but they have different signature
    public class PetService
    {
        public void PetStatus()
        {
            Console.WriteLine("PetStatus without params");
        }

        //ERROR
        //When calling this method we don't specify the return type (we only specify the name and the params that we send)
        //so the program does not know whict PetStatus() to call
        //public string PetStatus()
        //{
        //    return "";
        //}

        //the name of the method is the same, but it has two params - first param is of type string and the second is of type Cat
        public void PetStatus(string name, Cat cat)
        {
            Console.WriteLine($"Hello {name}. The {cat.Name} is {cat.GetAge()} years old");
        }

        //ERROR
        //When we call the method we don't specify the name of the params, only the type 
        //public void PetStatus(string catName, Cat catObject)
        //{
        //    Console.WriteLine($"Hello {name}. The {cat.Name} is {cat.Age} years old");
        //}

        //the name of the method is the same, but it has two params - here the first one is of type Cat and the second is of type string
        //THE ORDER OF THE PARAMS IS IMPORTANT
        public void PetStatus(Cat cat, string name)
        {
            //Console.WriteLine($"Hello {name}. The {cat.Name} is {cat.Age} years old");
            Console.WriteLine($"Hello {name}. The {cat.Name} is {cat.GetAge()} years old");
        }

        public void PetStatus(string name, Dog dog)
        {
            Console.WriteLine($"Hello {name}. The {dog.Name} is {dog.Color} years old");
        }

        public void PetStatus(Dog dog, string name)
        {
            Console.WriteLine($"Hello {name}. The {dog.Name} is {dog.Color} years old");
        }
    }
}

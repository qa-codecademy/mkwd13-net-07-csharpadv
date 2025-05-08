using Class04_Exercise01.Domain.Models;

namespace Class04_Exercise01.Domain
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets { get; set; }
        public PetStore()
        {
            Pets = new List<T>();
        }

        public void PrintPets()
        {
            foreach(T item in Pets)
            {
                item.PrintInfo(); //we can call PrintInfo because our T will inherit from Pet, which means that our T must implement the abstract method PrintInfo from Pet
            }
        }

        public void BuyPet(string name)
        {
            //we can call the Name property because our T will inherit from Pet, which means that our T must have a Name property
            T pet = Pets.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if (pet != null)
            {
                Pets.Remove(pet); //this pet has its owner now and is no longer a part of our pet store
                Console.WriteLine($"Your new pet is {name}");
            }
            else
            {
                Console.WriteLine($"There is no pet named {name}");
            }
        }
    }
}

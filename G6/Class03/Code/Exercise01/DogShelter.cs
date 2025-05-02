using Exercise01.Models;

namespace Exercise01
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog>()
            {
                new Dog()
                {
                    Id = 1, Name = "Sparky", Color="Black"
                },
                new Dog()
                {
                    Id = 2, Name ="Luna", Color ="Golden"
                },
                new Dog()
                {
                    Id = 3, Name ="Lucy", Color="White"
                }
            };
        }

        public static void PrintAll()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"{dog.Id}. {dog.Name} {dog.Color}");
            }
        }
    }
}

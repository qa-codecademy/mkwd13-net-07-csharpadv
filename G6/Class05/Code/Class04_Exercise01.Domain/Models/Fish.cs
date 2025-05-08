using Class04_Exercise01.Domain.Enums;

namespace Class04_Exercise01.Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public int Size { get; set; }
        public Fish(string name, int age, string color, int size) : base(name, age, PetTypeEnum.Fish)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is of type {Type.ToString()}, aged {Age} is of color {Color}");
        }
    }
}

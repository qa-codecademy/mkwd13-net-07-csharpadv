using Class04_Exercise01.Domain.Enums;

namespace Class04_Exercise01.Domain.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, int livesLeft, bool isLazy) : base(name, age, PetTypeEnum.Cat)
        {
            IsLazy = isLazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is of type {Type.ToString()} aged {Age} and lives left {LivesLeft}");
            if(IsLazy )
            {
                Console.WriteLine("This cat is lazy");
            }
            else
            {
                Console.WriteLine("This cat isn't lazy");
            }
        }
    }
}

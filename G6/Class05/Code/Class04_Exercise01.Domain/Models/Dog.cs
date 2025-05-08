using Class04_Exercise01.Domain.Enums;
namespace Class04_Exercise01.Domain.Models
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }
        public bool GoodBoy { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is of type {Type.ToString()} aged {Age} whose favourite food is {FavouriteFood}");
        }

        public Dog(string name, int age, string favouriteFood, bool goodBoy) : base(name, age, PetTypeEnum.Dog)
        {
            FavouriteFood = favouriteFood;
            GoodBoy = goodBoy;
        }
    }
}

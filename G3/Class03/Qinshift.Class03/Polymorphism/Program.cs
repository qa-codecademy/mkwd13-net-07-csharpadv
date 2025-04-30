
using Polymorphism;
using Polymorphism.Models;

Console.WriteLine("Hello, World!");

#region Runtime Polymorphism 
Pet randomPet = new Pet
{
    Name = "Chapo"
};
randomPet.Eat();

Dog dzeki = new Dog
{
    Name = "Dzeki",
    IsGoodBoi = true
};
dzeki.Eat();

Cat zuza = new Cat
{
    Name = "Zuza",
    IsLazy = true
};
zuza.Eat();
#endregion

#region Compile-Time Polymorphism
PetService petService = new PetService();

petService.PrintPetInfo(dzeki);
petService.PrintPetInfo();
petService.PrintPetInfo(dzeki, "Dzo");
petService.PrintPetInfo("Dzoana", dzeki);
#endregion
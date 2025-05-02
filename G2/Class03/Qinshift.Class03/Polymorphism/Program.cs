using Polymorphism;
using Polymorphism.Models;

Console.WriteLine("Hello, World!");

#region Runtime Polymorphism
Pet randomPet = new Pet
{
    Name = "Mali"
};
randomPet.Eat();

Dog zuco = new Dog
{
    Name = "Zuco",
    IsGoodBoy = true
};
zuco.Eat();

Cat mici = new Cat
{
    Name = "Mici",
    IsLazy = true
};
mici.Eat();
#endregion

#region Compile-Time Polymorphism
PetService petService = new PetService();

petService.PrintPetInfo();
petService.PrintPetInfo("Bob", mici);
petService.PrintPetInfo(mici, "Boba");
petService.PrintPetInfo(mici);

#endregion
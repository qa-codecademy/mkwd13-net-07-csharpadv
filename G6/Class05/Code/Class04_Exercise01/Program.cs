using Class04_Exercise01.Domain;
using Class04_Exercise01.Domain.Models;

PetStore<Dog> dogPetStore = new PetStore<Dog>();
dogPetStore.Pets.Add(new Dog("Sparky", 3, "Bacon", true));
dogPetStore.Pets.Add(new Dog("Lucy", 2, "Meat", false));

Console.WriteLine("Dogs in our pet store:");
dogPetStore.PrintPets();

//boxing
PetStore<Pet> petStore = new PetStore<Pet>();
petStore.Pets.Add(new Dog("Sparky", 3, "Bacon", true));
petStore.Pets.Add(new Cat("Lucy", 2, 9, true));
petStore.Pets.Add(new Fish("Bella", 1, "orange", 6));

Console.WriteLine("Welcome to our pet store");
petStore.PrintPets();

petStore.BuyPet("Bella");
petStore.PrintPets();

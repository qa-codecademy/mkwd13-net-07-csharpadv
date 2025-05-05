//Runtime polymorphism

using Polymorphism.Domain;
using Polymorphism.Domain.Service;

Pet firstPet = new Pet();
firstPet.Name = "PetName";
firstPet.Eat(); //method from Pet
Console.WriteLine(firstPet.Name);

Pet secondPet = new Cat();
secondPet.Name = "Lucy";
//secondPet.Age; ERROR because secondPet is of type Pet (boxing)
secondPet.Eat(); //from Cat

Cat cat = new Cat();
cat.Eat(); //from Cat

List<Pet> ourPets = new List<Pet>();
Dog dog = new Dog();
dog.Name = "Sparky";
dog.Eat(); //from Dog

//Boxing
ourPets.Add(dog);
ourPets.Add(cat);
ourPets.Add(firstPet);

foreach(Pet p in ourPets)
{
    p.Eat(); //in each iteration the method Eat will be called from the specific class (from cat it will be called from Cat, for dog from Dog and for firstPet from Pet)
}

//Compile time polymorphism
//the idea is that as long as the program knows which method to call we can have as many combinations as we need
//just the signature has to be differentS
PetService petService = new PetService();
petService.PetStatus();
petService.PetStatus("Petko", cat);
petService.PetStatus(cat, "Petko");
petService.PetStatus("Petko", dog);
petService.PetStatus(dog, "Petko");
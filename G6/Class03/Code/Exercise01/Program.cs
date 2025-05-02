using Exercise01;
using Exercise01.Models;

Dog dog1 = new Dog();
dog1.Name = ""; //string.Empty
dog1.Color = "Brown";
dog1.Id = 4;

dog1.Bark(); //Bark is a non-static method so we use the object to call it

//Dog.Validate -> the method is static so we need to use the class to access it
if (Dog.Validate(dog1))
{
    DogShelter.Dogs.Add(dog1);
}

DogShelter.PrintAll();
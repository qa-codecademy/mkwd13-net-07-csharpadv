using Exercise01.Domain;
using Newtonsoft.Json;
using System.Globalization;

string folderPath = @"..\..\..\Data";
string filePath = $@"{folderPath}\dogs.json";

//check if Directory and File exist, if not -> create them

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

List<Dog> dogs;
//we need to check if the file already contains a list of dogs - if so, then we should take that list and add the new dogs to the list and write the list in the file
using (StreamReader sr = new StreamReader(filePath))
{
    string content = sr.ReadToEnd(); //here we would have a json string
    dogs = JsonConvert.DeserializeObject<List<Dog>>(content);

    if(dogs == null)
    {
        dogs = new List<Dog>(); //we cannot say dogs.Add if dogs is null (it will throw an error)
    }
}

//loop where the user enters info about the dogs
while (true)
{
    Console.WriteLine("Please enter your Dog info:");
    Console.WriteLine("Name:");
    string name = Console.ReadLine();
    Console.WriteLine("Color:");
    string color = Console.ReadLine();
    Console.WriteLine("Age");

    if(!int.TryParse(Console.ReadLine(), out int age))
    {
        Console.WriteLine("Wrong input for age, please enter a valid number");
        continue; //it will skip this iteration and ho back to ln 34 and enter the next iteration
    }

    Dog dog = new Dog(name, color, age);
    dogs.Add(dog); //add the new dog to the list of dogs

    Console.WriteLine("Do you want to enter a new dog (y)?");
    string choice = Console.ReadLine();

    if(choice?.ToLower() != "y")
    {
        break; //it will end the loop
    }
}

using(StreamWriter sw = new StreamWriter(filePath))
{
    //we need to serialze our List<Dog> into JSON
    string result =JsonConvert.SerializeObject(dogs);
    sw.WriteLine(result);
}
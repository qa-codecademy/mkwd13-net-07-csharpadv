using Newtonsoft.Json;
using SerializationAndDeserialization;

string folderPath = @"..\..\..\Example";
string filePath = folderPath + @"\jsonfile.json";

Student student = new Student()
{
    FirstName = "Petko",
    LastName = "Petkovski",
    Age = 25,
    IsPartTime = false
};

CustomReaderWriter readerWriter = new CustomReaderWriter();

if (!Directory.Exists(folderPath)) //always do this check when working with folders
{
    Directory.CreateDirectory(folderPath);
}

//1. serialize the student object to json
string jsonStudent = CustomSerializerAndDeserializer.SerializeStudent(student);

//2. write JSON to file 
readerWriter.WriteToFile(jsonStudent, filePath);

//3.read json from
string jsonFromFile = readerWriter.ReadFromFile(filePath);

//4.parse (deserialze) the json into a student obj
Student parsedStudent = CustomSerializerAndDeserializer.DeserializeStudent(jsonFromFile);

Console.ReadLine();

//Newtonsoft.JSON
//we need to install a library (package) from nuget package manager
//we can install it for a concrete project ot multiple projects
//to install it you need to right click on solution or project -> manage nuget packages
Student anotherStudent = new Student
{
    FirstName = "Marko",
    LastName = "Markovski",
    Age = 25,
    IsPartTime = false
};

//1. serialize the student object to JSON
string jsonString = JsonConvert.SerializeObject(anotherStudent);

//2.write to file
readerWriter.WriteToFile(jsonString, filePath);

//3.read from file
string jsonFileContent = readerWriter.ReadFromFile(filePath);

//4. parse(deserialize) the json from the file
Student marko = JsonConvert.DeserializeObject<Student>(jsonFileContent);

Console.ReadLine();

//Just as good to know
List<int> integers = new List<int> { 1, 2, 3, 4, 5 };
string json = JsonConvert.SerializeObject(integers);

List<int> parsedInts = JsonConvert.DeserializeObject<List<int>>(json);
Console.ReadLine();
using Newtonsoft.Json;
using Qinshift.SerializeDeserialize.Entities;

Console.WriteLine("Hello, World!");

string directoryPath = @"../../../OutData";
string fileName = "myFirstJson.json";
string filePath = Path.Combine(directoryPath, fileName);
OurJsonSerializer Serializer = new OurJsonSerializer();
ReaderWriter ReaderWriter = new ReaderWriter();

if (!Directory.Exists(directoryPath))
{
    Directory.CreateDirectory(directoryPath);
}

Student bob = new Student
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 23,
    IsPartTime = false
};


#region Manual Serialization/Deserialization

string bobJsonString = Serializer.SerializeStudent(bob);
Console.WriteLine(bob);
Console.WriteLine(bobJsonString);

ReaderWriter.WriteInFile(filePath, bobJsonString);

string jsonStudent = ReaderWriter.ReadFile(filePath);
Console.WriteLine(jsonStudent);

Student deserializedStudent = Serializer.DeserializeStudent(jsonStudent);

#endregion


#region Newtonsoft JSON serialize / deserialize

Console.WriteLine("============ Using Newtonsoft.json ============");

string bobJsonNewtonsoft = JsonConvert.SerializeObject(bob);
Console.WriteLine(bobJsonNewtonsoft);

//object bobDeserializedNewtonSoft = JsonConvert.DeserializeObject(bobJsonNewtonsoft);
Student bobDeserializedNewtonSoft = JsonConvert.DeserializeObject<Student>(bobJsonNewtonsoft);

#endregion


Console.ReadLine();
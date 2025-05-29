using Newtonsoft.Json;
using Qinshift.SerializeDeserialize;

Console.WriteLine("Hello, World!");

string directoryPath = @"..\..\..\OurData";
string fileName = "myFirstJson.json";
string filePath = Path.Combine(directoryPath, fileName);

ReaderWriter ReaderWriter = new ReaderWriter();
OurJsonSerializer OurJsonSerializer = new OurJsonSerializer();

if (!Directory.Exists(directoryPath))
{
    Directory.CreateDirectory(directoryPath);
}

#region Manual Serialization/Deserialization

Student bob = new Student
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 23,
    IsPartTime = false
};
Console.WriteLine(bob);

string bobString = OurJsonSerializer.SerializeStudent(bob);
ReaderWriter.WriteFile(filePath, bobString);

string jsonStudent = ReaderWriter.ReadFile(filePath);
Student deserializedStudentJson = OurJsonSerializer.DeserializeStudent(jsonStudent);

#endregion


#region Using Newtonsoft.json
string bobSerializedJson = JsonConvert.SerializeObject(bob);

Student studentDeserialized = JsonConvert.DeserializeObject<Student>(bobSerializedJson);

Console.WriteLine(studentDeserialized.FirstName);
#endregion


Console.ReadLine();
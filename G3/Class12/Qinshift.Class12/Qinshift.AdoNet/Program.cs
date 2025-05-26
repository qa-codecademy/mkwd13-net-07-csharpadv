using Qinshift.AdoNet.Models;
using Qinshift.AdoNet.Services;

Console.WriteLine("Hello, World!");

void PrintInColor(string text, ConsoleColor color = ConsoleColor.White)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

void PrintStudents(List<Student> students)
{
    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }
}

string connectionString = "Server=.\\SQLEXPRESS;Database=SEDC_DEMO_SHARP;Trusted_Connection=True;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

StudentService studentService = new StudentService(connectionString);


PrintInColor("\n======= All Students =======", ConsoleColor.Cyan);
var allStudents = studentService.GetAllStudents();
PrintStudents(allStudents);


PrintInColor("\n======= Insert New Student =======", ConsoleColor.Cyan);

// ===> SQL Injection Example
// Insert the line bellow when calling InsertStudentMailicious
// John', 'Doe', '2000-01-01', '2025-01-01', 'M', 1234567890123, 'CA-2024-001'); DROP TABLE Student;--

string firstName = Console.ReadLine();

Student newStudent = new Student
{
    FirstName = firstName,
    LastName = "Doe",
    DateOfBirth = new DateTime(1999, 5, 24),
    EnrolledDate = DateTime.Now,
    Gender = 'M',
    NationalIdNumber = 123123123,
    StudentCardNumber = "SC-123-123"
};

//studentService.InsertStudentMalicious(newStudent); // Use this for SQL Injection demo
studentService.InsertStudent(newStudent);


Console.ReadLine();
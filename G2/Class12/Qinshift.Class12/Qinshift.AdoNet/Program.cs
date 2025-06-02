using Qinshift.AdoNet.Entities;
using Qinshift.AdoNet.Services;


string connectionString = "Server=.;Database=SECD_ACADEMY;Trusted_Connection=True;TrustServerCertificate=True;";


StudentService studentService = new StudentService(connectionString);

Console.WriteLine("Press 'ENTER' if you want to fetch all the students from the db!");
Console.ReadLine();

var students = studentService.GetAllStudents();

foreach (var student in students)
{
    Console.WriteLine($"Student: {student.FirstName} {student.LastName} | {student.StudentCardNumber}");
}



Console.WriteLine("Enter ID to fetch a student by id:");
string studentId = Console.ReadLine();

var studentById = studentService.GetStudentById(studentId);

Console.WriteLine($"Student: {studentById.FirstName} {studentById.LastName} - Gender: {studentById.Gender}");



Console.WriteLine("Enter ID to simulate sql injection:");
string userInput = Console.ReadLine();
string name = studentService.GetTestSqlInjectionName(userInput);
Console.WriteLine(name);



Console.WriteLine("Look now, a new student will be inserted!");

Student newStudent = new Student
{
    FirstName = "Martin",
    LastName = "Panovski",
    DateOfBirth = DateTime.Now,
    EnrolledDate = DateTime.Now,
    Gender = 'M',
    NationalIdNumber = 12345678,
    StudentCardNumber = "mp12345"
};

studentService.InsertStudent(newStudent);

var newStudentAdded = studentService.GetStudentById("571");
Console.WriteLine(newStudentAdded.FirstName);
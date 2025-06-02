using JsonDb;
using JsonDb.Models;

Database<Student> students = new Database<Student>();
Database<Subject> subjects = new Database<Subject>();

Subject newSubject = new Subject
{
    Title = "MVC",
    Description = "MVC",
    NumberOfModules = 10
};

Student student = new Student
{
    FirstName = "Marko",
    LastName = "Markovski",
    Age = 26
};

subjects.Insert(newSubject);
students.Insert(student);
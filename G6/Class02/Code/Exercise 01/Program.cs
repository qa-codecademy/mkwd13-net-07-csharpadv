using Exercise_01.Domain.Models;

Teacher teacher = new Teacher(1, "Petko", "petkovski_p", "123Test123", "Advanced C#");
teacher.PrintSubject();
teacher.PrintUser();

Student student = new Student(2, "Stefan", "stefanovski_s", "P@ssw0rd", new List<int> { 5, 5, 3 });
student.PrintUser();
student.PrintGrades();

//boxing
List<User> users = new List<User> { student, teacher };
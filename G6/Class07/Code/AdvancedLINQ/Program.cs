using AdvancedLINQ;
using AdvancedLINQ.Domain;
using AdvancedLINQ.Domain.Models;
using System.Security.Cryptography.X509Certificates;

List<Student> studentsOlderThan25 = QinshiftAcademy.Students.Where(x => x.Age > 25).ToList();
studentsOlderThan25.PrintEntities();

List<string> namesOfStudentsOlderThan25 = QinshiftAcademy.Students.Where(x => x.Age > 25).Select(x => x.FirstName).ToList();
namesOfStudentsOlderThan25.PrintSimple();

List<Student> studentsNamedBob = QinshiftAcademy.Students.Where(x => x.FirstName == "Bob").ToList();

var studentsNamedBobSql = (from student in QinshiftAcademy.Students //from all students in the list QinshiftAcademy.students
                           where student.FirstName == "Bob" //filter out the ones named Bob
                           select student).ToList(); //take the whole object (record) student

var agesOfstudentsNamedBobSql = (from student in QinshiftAcademy.Students //from all students in the list QinshiftAcademy.students
                           where student.FirstName == "Bob" //filter out the ones named Bob
                           select student.Age).ToList(); //take the age of the student

//First/Last/Single /OrDefault
//First => gets the first element, if no elements it will throw an error
//FirstOrDefault => gets the first element, if no elements it will return the default and will not throw an error
//Last => gets the last element, if no elements it will throw an error
//LastOrDefault => gets the last element, if no elements it will return the default and will not throw an error
//Single => gets the only element from the list, if no elements or more than one element - it will throw an error
//SingleOrDefault=> gets the only element from the list, if no elements - default value, if more than one element - throws an error

//Student studentStartingWithT = QinshiftAcademy.Students.Single(x => x.FirstName.StartsWith("T")); //ERROR
//Student studentStartingWithB = QinshiftAcademy.Students.SingleOrDefault(x => x.FirstName.StartsWith("B")); //ERROR
Student studentStartingWithT = QinshiftAcademy.Students.SingleOrDefault(x => x.FirstName.StartsWith("T")); //default

//SELECT/SELECTMANY

//here we get a list of lists which is complicated to work with
//here we will have a list of subjects for all the students that are part time
//the result is a list od lists
var subjectsOfPartTime = QinshiftAcademy.Students.Where(x => x.IsPartTime).Select(x => x.Subjects).ToList();

//selectMany flattens the list of lists. The members of each list in the list of lists become members of the main list
List<Subject> subjectsOfPartTimeStudents = QinshiftAcademy.Students.Where(x => x.IsPartTime)
                                          .SelectMany(x => x.Subjects).ToList();


//Except => gets all except the ones that we tell it to exclude
List<Student> exceptBob = QinshiftAcademy.Students.Except(studentsNamedBob).ToList();

//Any/All

bool checkIfAnyPartTime = QinshiftAcademy.Students.Any(x => x.IsPartTime); //true - checks if at least one item is part time
bool checkIfAllArePartTime = QinshiftAcademy.Students.All(x => x.IsPartTime); //false - checks if all the items are part time

//Distinct/DistinctBy - removes duplicates
List<int> numbers = new List<int>() { 4, 6, 4, 6 };
List<int> distinctNumbers = numbers.Distinct().ToList();
distinctNumbers.PrintSimple();

List<Student> distinctByAge = QinshiftAcademy.Students.DistinctBy(x => x.Age).ToList();//when we work with objects, we cannot compere them just with distinct, we need to tell the program based on which properties to compare the elements


//OrderBy/OrderByDescendig
List<Student> studentsOrderedByAge = QinshiftAcademy.Students.OrderBy(x => x.Age).ToList(); //order by is ascending by default
List<Student> studentsOrderedByAgeDesc = QinshiftAcademy.Students.OrderByDescending(x => x.Age).ToList();

List<Student> studentsOrderedByName = QinshiftAcademy.Students.OrderBy(x => x.FirstName).ToList();
studentsOrderedByName.PrintEntities();
using Qinshift.Class06.LinqMethods;
using Qinshift.Class06.LinqMethods.Entities;
using Qinshift.Class06.LinqMethods.Helpers;

// WHERE() 

Console.WriteLine("=== WHERE ===");
//SQL like
IEnumerable<Student> findBobSql = from std in Database.Students
                                  where std.FirstName == "Bob"
                                  select std;

// Lambda LINQ syntax
IEnumerable<Student> findBobLamda = Database.Students
                                            .Where(x => x.FirstName == "Bob");

findBobSql.ToList().PrintEntities();
findBobLamda.ToList().PrintEntities();


// SELECT
Console.WriteLine("=== SELECT ===");

//SQL like

List<string> firstNamesSql = (from std in Database.Students
                             select  std.FirstName).ToList();

List<string> studentFullNamesSql = (from std in Database.Students
                                    select $"{std.FirstName} {std.LastName}").ToList();

firstNamesSql.PrintSimple();
studentFullNamesSql.PrintSimple();

// Lambda - LINQ syntax

List<string> firstNamesLinq = Database.Students
    .Select(x => x.FirstName).ToList();

List<string> studentFullNamesLinq = Database.Students
    .Select(x => $"{x.FirstName} {x.LastName}").ToList();

firstNamesLinq.PrintSimple();
studentFullNamesLinq.PrintSimple();



Console.WriteLine("=== COMPLEX QUERIES ===");

List<Student> partTimeProgrammingStudentsSql = (from std in Database.Students
                                  where std.IsPartTime && std.Subjects is not null
                                  where (from sub in std.Subjects
                                         where sub.Type == Academy.Programming
                                         select sub).ToList().Count != 0
                                  select std).ToList();

partTimeProgrammingStudentsSql.PrintEntities();

// Linq syntax
List<Student> partTimeProgrammingStudentsLinq =
    Database.Students.Where(x => x.IsPartTime && x.Subjects is not null)
                     .Where(x => x.Subjects.Where(y => y.Type == Academy.Programming)
                     .ToList().Count != 0)
                     .ToList();

partTimeProgrammingStudentsLinq.PrintEntities();


// FIRST / SINGLE / LAST / ORDEFAULT
Console.WriteLine("=== FIRST / SINGLE / LAST / ORDEFAULT  ===");

List<string> emptyListOfStrings = new();
List<Student> emptyListOfStudents = new();

Console.WriteLine(Database.Students.First().Info());
Console.WriteLine(Database.Students.First(x => x.FirstName.StartsWith('T')).Info());

Console.WriteLine(emptyListOfStudents.FirstOrDefault());


Console.WriteLine(Database.Students.SingleOrDefault(x => x.Id == 123)?.Info());


//Select Many
Console.WriteLine("=== SELECT MANY ===");

var partTimeStudentsAllSubejects = 
        Database.Students.Where(x => x.IsPartTime && x.Subjects is not null)
        .SelectMany(x => x.Subjects).ToList();

//partTimeStudentsAllSubejects.PrintEntities();


List<Subject> partTimeStudentsAllSubjectsDistinct = partTimeStudentsAllSubejects.Distinct().ToList();
//partTimeStudentsAllSubjectsDistinct.PrintEntities();

var exceptPartTime = Database.Students.Except(Database.Students.Where(x => x.IsPartTime)).ToList();

var exceptWithWhere = Database.Students.Where(x => !x.IsPartTime).ToList();


exceptPartTime.PrintEntities();


bool ptStudents = Database.Students.All(x => x.IsPartTime);

bool anyPtStudents = Database.Students.Any(x => x.IsPartTime);


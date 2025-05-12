using LinqMethods.Helpers;
using LinqMethods.Models;

ConsoleHelper.PrintInColor("\n==================== LINQ ====================\n", ConsoleColor.DarkCyan);
// LINQ (Language Integrated Query) is a powerful feature in C# and other .NET languages that allows you to query collections of data (like arrays, lists, databases, etc.). 


ConsoleHelper.PrintInColor("\n================== Where ==================\n", ConsoleColor.Red);
// Where filters items by an expression that must be true or false
// Where always returns IEnumerable of the same type as the target collection
// Returns the number of elements that met the condition

// LINQ with lambda
IEnumerable<Student> findBobs = SEDC.Students.Where(s => s.FirstName == "Bob");
List<Student> findBobsToList = SEDC.Students.Where(s => s.FirstName == "Bob").ToList();
findBobsToList.PrintEntities();

// SQL-like LINQ syntax
IEnumerable<Student> findBobsSql = from s in SEDC.Students
                                   where s.FirstName == "Bob"
                                   select s;
findBobsSql.ToList().PrintEntities();

// Step by Step
List<Student> bobStudents = new();
foreach (Student item in SEDC.Students)
{
    if (item.FirstName == "Bob")
    {
        bobStudents.Add(item);
    }
}

// LINQ with predefined method
Func<Student, bool> isBob = student => student.FirstName == "Bob";
IEnumerable<Student> findBobsFunc = SEDC.Students.Where(isBob);


ConsoleHelper.PrintInColor("\n================== Select ==================\n", ConsoleColor.Yellow);
// Select creates a collection with a different form of the initial collection by an expression that can be any value
// Select returns IEnumerable with the type of the value in the expression
// Returns the same number of elements as the initial collection

// Example: Return students names
List<string> studentsNames = SEDC.Students.Select(student => student.FirstName).ToList();

// [ {id, fname, lname}, {id, fname, lname}, {id, fname, lname} ]
// .Select(s => s.fname)
// [ fname, fname, fname ]


// Step by Step
List<string> studentsFirstNames = new();
foreach (Student item in SEDC.Students)
{
    studentsFirstNames.Add(item.FirstName);
}

// Example: Get only the fullname and age of the students
var studentsBaseInfoAnonymousObject = SEDC.Students.Select(s => new { s.FirstName, s.Age }).ToList();
Console.WriteLine(studentsBaseInfoAnonymousObject[1].FirstName);


List<StudentBasicInfo> studentsBaseInfo = SEDC.Students
    .Where(s => s.Age > 25)
    .Select(s => new StudentBasicInfo
    {
        Age = s.Age,
        FullName = $"{s.FirstName} {s.LastName}"
    }).ToList();


ConsoleHelper.PrintInColor("\n================== First/Single/Last (OrDefault) ==================\n", ConsoleColor.Green);
// First => Gets first element, if no elements it will throw error
// FirstOrDefault => Gets first element, if no elements will return default and will not throw error
// Last => Gets last element, if no elements it will throw error
// LastOrDefault => Gets last element, if no elements will return default and will not throw error
// Single => Gets the only element from list, if more than one elements or no elements will throw error
// SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error

List<Student> emptyStudentsList = new();

Console.WriteLine(SEDC.Students.First().GetInfo());
//Console.WriteLine(emptyStudentsList.First().GetInfo()); // EXCEPTION
// Console.WriteLine(emptyStudentsList.First());
Console.WriteLine(emptyStudentsList.FirstOrDefault());
// Console.WriteLine(SEDC.Students.Single(s => s.Age > 30));
// Console.WriteLine(SEDC.Students.SingleOrDefault(s => s.Age > 30));


ConsoleHelper.PrintInColor("\n================== Select Many ==================\n", ConsoleColor.Red);
// It flatens list of lists
// Flattening => When we make one list out of multiple lists of the same type

// Example: subjects of all part-time students

// Select
// Issue because it does not give all the results in one list, but creates a list of lists
List<List<Subject>> partTimeStudentsSubjectsSelect = SEDC.Students
    .Where(s => s.IsPartTime)
    .Select(s => s.Subjects)
    .ToList();

// SelectMany
// Flatens all the lists into one list
List<Subject> partTimeStudentsSubjects = SEDC.Students
    .Where(s => s.IsPartTime)
    .SelectMany(s => s.Subjects)
    .ToList();


ConsoleHelper.PrintInColor("\n================== Distinct/DistinctBy ==================\n", ConsoleColor.Yellow);
// Removes all duplicate values from a collection
// Returns IEnumerable of the same type as the original collection

// Distinct 
List<Subject> distinctSubjects = partTimeStudentsSubjects
    .Distinct()
    .ToList();
distinctSubjects.PrintEntities();

// Distinct By
List<Subject> distinctByTypeSubjects = partTimeStudentsSubjects
    .DistinctBy(s => s.Type)
    .ToList();
distinctByTypeSubjects.PrintEntities();


ConsoleHelper.PrintInColor("\n================== Any/All ==================\n", ConsoleColor.Green);


// Any
// Checks if there is at least one item in a collection that follows an expression
// Returns true or false depending on the result
bool hasBob = SEDC.Students.Any(s => s.FirstName == "Bob");
Console.WriteLine(hasBob); // true
bool hasShortLastName = SEDC.Students.Any(s => s.LastName.Length <= 2);
Console.WriteLine(hasShortLastName); // true

// All
// Checks if all items of a collection follow a particular expression
// Returns true or false depending on the result
bool hasBobAll = SEDC.Students.All(s => s.FirstName == "Bob");
Console.WriteLine(hasBobAll); // false
bool hasShortLastNameAll = SEDC.Students.All(s => s.LastName.Length <= 2);
Console.WriteLine(hasShortLastNameAll); // false
bool areAdults = SEDC.Students.All(s => s.Age > 18);
Console.WriteLine(areAdults); // true


ConsoleHelper.PrintInColor("\n================== Except ==================\n", ConsoleColor.Red);

List<Student> exceptPartTime = SEDC.Students
    .Except(SEDC.Students.Where(s => s.IsPartTime))
    .ToList();





ConsoleHelper.PrintInColor("\n================== OrderBy/ThenBy (Descending) ==================\n", ConsoleColor.Yellow);

List<Student> sortedStudents = SEDC.Students
    .OrderBy(s => s.FirstName)
    .ToList();
sortedStudents.PrintEntities();

List<Student> sortedStudentsDesc = SEDC.Students
    .OrderByDescending(s => s.FirstName)
    .ToList();
sortedStudentsDesc.PrintEntities();

List<Student> sortedStudentsThenBy = SEDC.Students
    .OrderBy(s => s.FirstName)
    .ThenBy(s => s.Age)
    .ThenBy(s => s.Id)
    .ToList();
sortedStudentsThenBy.PrintEntities();


ConsoleHelper.PrintInColor("\n================== GroupBy ==================\n", ConsoleColor.Green);

var groupByAcademy = SEDC.Subjects
    .GroupBy(s => s.Type)
    .ToList();

groupByAcademy[0].ToList().PrintEntities();
groupByAcademy[(int)Academy.Networks].ToList().PrintEntities();



/* 
    MORE USEFUL LINQ METHODS
    
    1) Max/MaxBy & Min/MinBy
    2) Count()
    3) Sum(), Average()
    4) Take(), Skip()
    5) Aggregate()
    etc...
*/
Console.ReadLine();
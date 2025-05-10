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

// Step by Step
List<string> studentsFirstNames = new();
foreach (Student item in SEDC.Students)
{
    studentsFirstNames.Add(item.FirstName);
}




ConsoleHelper.PrintInColor("\n================== First/Single/Last (OrDefault) ==================\n", ConsoleColor.Green);




ConsoleHelper.PrintInColor("\n================== Select Many ==================\n", ConsoleColor.Red);





ConsoleHelper.PrintInColor("\n================== Distinct/DistinctBy ==================\n", ConsoleColor.Yellow);




ConsoleHelper.PrintInColor("\n================== Any/All ==================\n", ConsoleColor.Green);






ConsoleHelper.PrintInColor("\n================== Except ==================\n", ConsoleColor.Red);






ConsoleHelper.PrintInColor("\n================== OrderBy/ThenBy (Descending) ==================\n", ConsoleColor.Yellow);






ConsoleHelper.PrintInColor("\n================== GroupBy ==================\n", ConsoleColor.Green);









Console.ReadLine();
using LinqMethods.Helpers;
using LinqMethods.Models;

ConsoleHelper.PrintInColor("\n==================== LINQ ====================\n", ConsoleColor.DarkCyan);




ConsoleHelper.PrintInColor("\n================== Where ==================\n", ConsoleColor.Red);
IEnumerable<Student> findBobs = SEDC.Students.Where(s => s.FirstName == "Bob");
List<Student> findBobsToList = SEDC.Students.Where(s => s.FirstName == "Bob").ToList();
findBobsToList.PrintEntities();


ConsoleHelper.PrintInColor("\n================== Select ==================\n", ConsoleColor.Yellow);




ConsoleHelper.PrintInColor("\n================== First/Single/Last (OrDefault) ==================\n", ConsoleColor.Green);




ConsoleHelper.PrintInColor("\n================== Select Many ==================\n", ConsoleColor.Red);





ConsoleHelper.PrintInColor("\n================== Distinct/DistinctBy ==================\n", ConsoleColor.Yellow);




ConsoleHelper.PrintInColor("\n================== Any/All ==================\n", ConsoleColor.Green);






ConsoleHelper.PrintInColor("\n================== Except ==================\n", ConsoleColor.Red);






ConsoleHelper.PrintInColor("\n================== OrderBy/ThenBy (Descending) ==================\n", ConsoleColor.Yellow);






ConsoleHelper.PrintInColor("\n================== GroupBy ==================\n", ConsoleColor.Green);









Console.ReadLine();
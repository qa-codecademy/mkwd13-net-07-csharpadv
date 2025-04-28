using Abstractions.Entities.BaseEntity;
using Abstractions.Entities.Models;

Console.WriteLine("Hello, World!");

#region Creating Instances
Developer dev = new Developer(1, "Bob", "Bobsky", 23, "123-123-1234", new List<string> { "JavaScript", "C#", "Java" }, 150);

Tester tester = new(2, "Jill", "Wayne", 32, "234-234-2345", 14);

Operations ops = new(3, "Greg", "Gregsky", 38, "345-345-3456", new List<string> { "Optimus", "PickPro", "ProtoBeat" });

DevOps devOps = new(4, "John", "Doe", 50, "456-456-4567", false, true);

QAEngineer qa = new(5, "Steve", "Stevenson", 33, "567-567-5678", new List<string> { "Selenium", "Puppeteer" });

// => Can't create an instance of an abstract class
//Human human = new Human();

#endregion


#region Testing all methods

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("The Developer:");
Console.WriteLine(dev.GetInfo());
dev.Greet("Students");
dev.Code();
Console.ResetColor();

Console.WriteLine("----------------");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("The Tester:");
Console.WriteLine(tester.GetInfo());
tester.Greet("Students");
tester.TestFeature("Log In");
Console.ResetColor();

Console.WriteLine("----------------");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("The IT Operations Specialist:");
Console.WriteLine(ops.GetInfo());
ops.Greet("Students");
Console.WriteLine($"Infrastructure OK: {ops.CheckInfrastructure(200)}");
Console.ResetColor();

Console.WriteLine("----------------");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("The DevOps:");
Console.WriteLine(devOps.GetInfo());
devOps.Greet("Students");
devOps.Code();
Console.WriteLine($"Infrastructure OK: {ops.CheckInfrastructure(200)}");
Console.ResetColor();

Console.WriteLine("----------------");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("The QA Engineer:");
Console.WriteLine(qa.GetInfo());
qa.Greet("Students");
qa.Code();
qa.TestFeature("Order");
Console.ResetColor();

Console.ReadLine();
#endregion
using Abstractions.Entities.BaseEntity;
using Abstractions.Entities.Models;

Console.WriteLine("Hello, World!");

#region Creating Instances
Developer dev = new Developer(1, "Bob", "Bobsky", 23, "123-123-1234", new List<string> { "JavaScript", "C#", "Java" }, 150);

Tester tester = new(2, "Jill", "Wayne", 32, "234-234-2345", 14);

Operations ops = new(3, "Greg", "Gregsky", 38, "345-345-3456", new List<string> { "Optimus", "PickPro", "ProtoBeat" });

DevOps devOps = new(4, "John", "Doe", 50, "456-456-4567", false, true);

QAEngineer qa = new(5, "Steve", "Stevenson", 33, "567-567-5678", new List<string> { "Selenium", "Puppeteer" });

//Human human = new Human();

#endregion
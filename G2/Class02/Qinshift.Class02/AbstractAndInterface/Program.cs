using AbstractAndInterface.Entities;


#region Abstract classes


//Human human = new Human();  => This will not work. Cannot instantiate object from abstract class

Developer dev = new Developer("Martin Panovski", 31, 070222555,
    new List<string> { "C#", "JavaScript", "PhP" }, 7);

Tester tester = new Tester("Bob Bobsky", 32, 078234567, 100);


Console.WriteLine("The Developer:");
Console.WriteLine(dev.GetInfo());
dev.Greet("Students");
dev.Code();


Console.WriteLine("---------------------------");
Console.WriteLine("The tester:");
Console.WriteLine(tester.GetInfo());
tester.Greet("Students");
tester.TestFeature("Demo example feature");




#endregion
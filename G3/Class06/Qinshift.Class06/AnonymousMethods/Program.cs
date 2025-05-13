// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================== ANONYMOUS METHODS ==================\n");
Console.ResetColor();

// in Javascript
// let someFunc = function () {}
// someFunc()
// let sum = (num1, num2) => num1 + num2;
// sum(10,20) // 30

List<string> names = new()
{
    "Bob", "Jill", "John", "Greg", "Stef", "Anna"
};
List<string> emptyList = new();


// Same thing as bellow
//foreach (string name in names)
//{
//    if (name == "John")
//    {
//        Console.WriteLine(name); 
//    }
//}

string johnName = names.Find(name => name == "John");// one line lambda expression

// Lambda expression (arrow function): name => name == "John"
// => anonymous method with one parameter (*name*) and return value of type bool (*name == "John"* returns bool)

Console.WriteLine(johnName);

#region Func
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n================== Func ==================\n");
Console.ResetColor();

// Func => type of delegate 
// => defines the type of a method (what type and how many parameters will it have and what is the return type)
// => always has a return value ! (the type of the return value is always the last type in the < > brackets)

// ===> Example of a Func with no parameters
// bool -> return value
Func<bool> isNamesEmpty = () => names.Count == 0;
Console.WriteLine($"isNamesEmpty: {isNamesEmpty()}");

// ===> Example of a Func with 1 parameter
// string -> parameter no. 1 / bool -> return type
Func<string, bool> findJohn = name => name == "John";
Console.WriteLine(findJohn("Blabla")); // false

// ===> Example of a Func with 2 parameters
// int -> parameter no. 1 / int -> parameter no. 2 / bool -> return type
Func<int, int, bool> isNumLarger = (num1, num2) => num1 > num2;
Console.WriteLine(isNumLarger(10, 3));

// ===> Example of a Func with 2 parameters
// int -> parameter no. 1 / int -> parameter no. 2 / int -> return type
Func<int, int, int> sum = (num1, num2) => num1 + num2;
Console.WriteLine(sum(140, 60));

// ===> Example of a Func with 4 parameters
Func<int, string, double, bool, string> getUserInfo = (id, name, salary, isActive) =>
{
    //return true;
    string result = $"ID: {id}. Name: {name}. Salary: {salary}. IsActive: {isActive}.";
    return result;
};

string userInfo = getUserInfo(10, "Bobby Bobsky", 3333.333, true);
Console.WriteLine("User info " + userInfo);


//Func<void> printHello = () => Console.WriteLine("Hello, it's me!");
#endregion


#region Action
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n================== Action ==================\n");
Console.ResetColor();
// Action is also delegate that is always void !

Action sayHello = () => Console.WriteLine("Hello, it's me again!");
sayHello();

Action<string> printRed = text =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
    //return 123;
};

printRed("Hello Red");

Action<string, ConsoleColor> printInColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
};

printInColor("Print in MAGENTA :D", ConsoleColor.Magenta);
#endregion


#region Predicate
// In C#, a Predicate<T> is a built-in generic delegate that represents a method which takes a single parameter of ANY type (T) and returns a bool
Predicate<string> nameStartsWithA = name => name.StartsWith('A');

Console.WriteLine(nameStartsWithA("Bobi"));
//string nameOnA = names.Find(name => name.StartsWith('A'));
string nameOnA = names.Find(nameStartsWithA);
Console.WriteLine("The name on A is " + nameOnA);
#endregion

// Example: find all names that start with the letter "J"
Func<string, bool> nameStartsWithJ = name => name.StartsWith('J');
IEnumerable<string> namesOnJ = names.Where(nameStartsWithJ);


Console.ReadLine();
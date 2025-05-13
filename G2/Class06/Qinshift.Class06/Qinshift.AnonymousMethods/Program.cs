int Sum(int x, int y)
{
    return x + y;
}

int Diff(int x, int y)
{
    return x - y;
}

int Multiply(int x, int y)
{
    return x * y;
}

Console.WriteLine("========================== Func =========================");
List<string> names = new() { "Martin", "Slave", "Ana", "Sandra", "Angel" };

#region Func
// Func is a special type of delegate in C#
// and it ALWAYS returns a value

Func<int, int, int> sumOfTwo = (x, y) =>  x + y;
Func<int, int, int> diffOfTwo = (x, y) => x - y;
Func<int, int, int> mulOfTwo = (x, y) => x * y;

Func<int, int, bool> checkIfLarger = (x, y) =>
{
    if (x > y)
        return true;
    return false;
};

Console.WriteLine($"The sum of 5 and 10 is: {sumOfTwo(5, 10)}");
Console.WriteLine($"The difference of 10 and 4 is: {diffOfTwo(10, 4)}");
Console.WriteLine($"The product of 123 and 10 is: {mulOfTwo(123, 10)}");
if(checkIfLarger(10, 20))
{
    Console.WriteLine("10 is larger");
}
else
{
    Console.WriteLine("20 is larger");
}

Func<List<string>, bool> isListEmpty = list => list.Count == 0;

Console.WriteLine($"Is the list of names empty: {isListEmpty(names)}");
#endregion

Console.WriteLine("========================== Action =========================");
#region Action
//Action is a special type of delegate in C#
//which can accept input parameters but DOESN'T return anything
//It ALWAYS return VOID

// Example of Action that has no input parameters
Action hello = () => Console.WriteLine("Hello there!");
hello();

// Example of Action that has one input parameters

Action<string> printInRed = (text) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
};

printInRed("This will be printed in red color!");

Action<string, ConsoleColor> printInColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
};
#endregion

Console.WriteLine("========================== Higher Order Function Use =========================");

#region Higher Order function use

string foundMartin = names.Find(x => x == "Martin");
Console.WriteLine(foundMartin);

Predicate<string> isAngel = x => x == "Angel";

string foundAngel = names.Find(isAngel);
Console.WriteLine(foundAngel);
#endregion



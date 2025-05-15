//Lambda expressions

List<string> names = new List<string>() { "Bob", "Petko", "John", "Nikola", "Marko" };

string foundBob = names.FirstOrDefault(x => x.ToLower() == "Bob".ToLower());

//Func => used to store method that returns a value and can have params or no params
//we are reading from left to right (Func<int, string, bool>) that means that we have a function
//with two params and a return type. The return type here will be bool. The first param is int and the second param is string

//Func ALWAYS has a return type, so this is a function that has no params and returns a value of type int
                      //we have params then an arrow then the body of the method
Func<int> sumOdTwoAndFive = () => 2 + 5;

Console.WriteLine(sumOdTwoAndFive());

//we are storing anon method that takes one param of type Lits<string> and returns a bool
Func<List<string>, bool> checkIfListIsEmpty = (list) => list.Count == 0;
bool isEmpty = checkIfListIsEmpty(names); //we use the name that we stored the anon method in to call it

//two params that are int and return type also int
Func<int, int, int> sum = (x, y) => x + y;
Console.WriteLine(sum(3,5));

//if we have many lines of code in the body of the anon method, we use {}
//two params that are int and a return type bool
Func<int, int, bool> isFirstNumberLarger = (x, y) =>
{
    if(x > y)
    {
        return true;
    }
    else
    {
        return false;
    }

};

List<int> ints = new List<int>() { 2, 5, 6, 7, 8 };
List<int> secondListOfInts = new List<int>() { 3, 5, 6, 46, 8, 9 };

//one int param and return type bool
Func<int, bool> checkEven = x => x % 2 == 0;

List<int> evenNumbers = ints.Where(checkEven).ToList();
//we can reuse the checkEven method, so that we don't need to write the check logic each time
List<int> evenNumbersFromSecondInts = secondListOfInts.Where(checkEven).ToList();

//one param string and return type bool
Func<string, bool> startsWithJ = x => x.StartsWith("J");
List<string> namesStartingWithJ = names.Where(startsWithJ).ToList();

//Action - Action is ALWAYS VOID

//we have no params here and no return type because Action is always void
Action sayHello = () => Console.WriteLine("Hello");
sayHello();

//one param - string
//when we have multi line code in the method body we use {}
Action<string> printRed = x =>
{
    Console.ForegroundColor = ConsoleColor.Red; //we set the color that is shown in the console to be red
    Console.WriteLine(x); //our string param will be printed in red
    Console.ResetColor(); //we reset the color back to default
};

printRed("Hello G6");

//two params string and ConsoleColor and no return type (Action is always void)
Action<string, ConsoleColor> printColor = (message, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
};

printColor("We are learning C# and it is hard and fun", ConsoleColor.Green);

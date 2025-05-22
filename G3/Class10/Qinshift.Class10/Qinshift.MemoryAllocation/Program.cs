using Qinshift.Helpers;
using Qinshift.MemoryAllocation;


#region Value & Reference types
ExtendedConsole.PrintInColor("\n=============== STACK & HEAP ===============\n\n", ConsoleColor.DarkCyan);

// STACK
// => used for static memory allocation
// => stores value types and reference to the reference type

// HEAP
// => used for dynamic memory allocation
// => stores the actual data of the reference types
// => is managed by the garbage collector (GC), which automatically frees up memory that is no longer being used

ExtendedConsole.PrintInColor("\n=============== Value type & Reference type ===============\n", ConsoleColor.Cyan);
// VALUE TYPES => both *reference* (variable) and *value* are stored on the STACK
// bool, byte, char, int, decimal, double, enum, float, long, short, struct...

// REFERENCE TYPES => *reference* is stored on the STACK, the actual *value* on the HEAP
// classes (objects), interface, delegate, *string*...

// *STRINGS* => special type, are considered reference type

Console.WriteLine("======= Value types =======\n");
int num1 = 10;
int num2 = num1; // it assignes only the value to the new variable num2
num2 = 50; // the change won't affect num1 
Console.WriteLine(num1); // 10
Console.WriteLine(num2); // 50


Console.WriteLine("\n======= Reference types =======\n");

// ===> Example: List<int>
List<int> ints1 = new() { 1, 2, 3 };
List<int> ints2 = ints1; // passing reference to the ints1 list
ints2[1] = 100; // will affect the original ints1 list

ints1.ForEach(i => Console.WriteLine(i)); // 1, 100, 3
Console.WriteLine("=======");
ints2.ForEach(i => Console.WriteLine(i)); // 1, 100, 3


// ===> Example: User
User john = new User
{
    FirstName = "John",
    LastName = "Doe",
    Age = 29
};

User john2 = john; // passing reference to the john object
john2.Age = 90; // will affect john object as well
john.LastName = "BLAAA"; // will affect john2 object as well

john.PrintInto(); // John BLAAA (90)
john2.PrintInto(); // John BLAAA (90)


Console.WriteLine("\n======= Strings =======\n");

// ===> Example: *String*
string stringOne = "String One";
string stringTwo = stringOne;
stringTwo = "String Two";
// ***NOTE*** Even though strings are REFERENCE type and the values are stored on the heap, they behave like VALUE types in many ways

Console.WriteLine(stringOne); // String One
Console.WriteLine(stringTwo); // String Two

#endregion


#region Objects Lifecycle

ExtendedConsole.PrintInColor("\n\n=============== OBJECTS LIFECYCLE ===============\n", ConsoleColor.Yellow);

static void TestObject()
{
    User bob = new User("Bob", "Bobsky", 33);
    // ===> when using *named parameters* the order doesn't metter
    User john = new User(age: 23, firstName: "John", lastName: "Doe");
    Console.WriteLine("Logic with bob object...");
    bob.PrintInto();
    Console.WriteLine("More logic...");
    john.PrintInto();
    Console.WriteLine("Okay, we don't need the objects anymore. Throw them in the trash...");
}

TestObject();
// GC.Collect(); // if you don't want to wait for the Garbage Collector to automatically collect the disposed objects ... (used for DEMO purposes)

#endregion


Console.ReadLine();
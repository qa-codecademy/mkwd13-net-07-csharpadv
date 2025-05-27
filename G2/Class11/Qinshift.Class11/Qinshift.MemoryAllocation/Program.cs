using Qinshift.Helpers;
using Qinshift.MemoryAllocation;

Console.WriteLine("Hello, World!");

ExtendedConsole.PrintInColor("\n=============== STACK & HEAP ===============\n\n", ConsoleColor.DarkCyan);

// STACK
// => part of the RAM memory used for static memory allocation
// => stores value types and reference to the reference type

// HEAP
// => part of the RAM memory used for dynamic memory allocation
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
List<int> ints1 = new List<int> { 1, 2, 3 };
List<int> ints2 = ints1; // passing reference to the ints1 list
ints1[1] = 1000; // will affect the original ints1 list
//ints2[0] = 324324;

ints1.ForEach(n => Console.WriteLine(n)); // 1 1000 3
ints2.ForEach(n => Console.WriteLine(n)); // 1 1000 3


// ===> Example: User
User john = new User
{
    FirstName = "John",
    LastName = "Doe",
    Age = 32
};

User john2 = john; // passing reference to the john object
john2.Age = 80; // will affect john object as well

john.PrintInfo(); 
john2.PrintInfo();


Console.WriteLine("\n======= Strings =======\n");

// ===> Example: *String*
string stringOne = "String One";
string stringTwo = stringOne;
stringTwo = "String Two";
// ***NOTE*** Even though strings are REFERENCE type and the values are stored on the heap, they behave like VALUE types in many wayss

Console.WriteLine(stringOne);
Console.WriteLine(stringTwo);


Console.WriteLine("\n\n=============== OBJECTS LIFECYCLE ===============\n");

void TestObject()
{
    User bob = new User("Bob", "Bobsky", 23);
    User johnny = new User("John", "Johnsky", 34);
    Console.WriteLine("Logic with bob object...");
    bob.PrintInfo();
    Console.WriteLine("More logic ...");
    johnny.PrintInfo();
    Console.WriteLine("Okay, we don't need the objects anymore. Throw them in the trash...");

}
TestObject();
// Force garbage collection
GC.Collect(); // Important: This is only for demo. You should never do this in code — let the GC handle it automatically

Console.ReadLine();
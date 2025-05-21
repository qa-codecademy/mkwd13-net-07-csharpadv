using Qinshift.Helpers;
using Qinshift.Nullable;

ExtendedConsole.PrintInColor("\n================== NULLABLE ==================\n\n", ConsoleColor.Cyan);

// ===> VALUE types are NOT NULLABLE by default


//int number = null; // won't work because int is not nullable by default
int? number = null;// with the '?' we can make the non-nullable types to be nullable

double? doubleNumber = null;
// bool isTrue = null; // won't work
bool? isTrue = null;
//number = 10;

//DateTime date = null; // Error
DateTime? date = null;

Console.WriteLine(number.HasValue ? number.Value : "No value");

// NOTE: string is nullable by default
string text = null;
string? text2 = null; // here we explicitly tell that this variable is nullable

// ===> PERSON EXAMPLE
Person bob = new Person();

Console.WriteLine(bob.Name?.Length);
Console.WriteLine(bob.Id); // 0 by default
Console.WriteLine(bob.Score); // null, because it is int?
Console.WriteLine(bob.IsEmployed); // false by default
Console.WriteLine(bob.HasPet); // null 
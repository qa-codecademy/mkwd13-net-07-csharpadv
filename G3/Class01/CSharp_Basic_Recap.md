# C# BASIC RECAP 

## C# as a programming language

C# is one of many programming languages with which we can build back-end web applications. This means that with this language we will build an application that will run and be stationed on a server machine. The language was built by Microsoft in 2002 and can be used for all kinds of applications, from desktop to mobile and web. For this language to be running it has to be compiled. Compiling is the process of turning a source code written in one language into another language that can run that code ( assembly code for some languages or some intermediate language for languages such as C# )

## .NET and .NET Core

.NET is a framework that provides many features for building applications with Microsoft languages such as C#. It is the platform that provides building and compiling C# code. It also acts as a management tool for all libraries that are built for C# so that they can be included and used easily. This framework also holds some important features such as managing memory or monitoring performance. There are multiple types of the .NET framework:

* .NET Full Framework - The first version of the .NET framework that works only on Windows machines
* .NET Core - Different version that is built to run code on different platforms
* .NET 5 - The next version of .NET succeeding .NET Core ( More similar to Core than Full Framework )
  * The "Core" was dropped from the name to represent a single future version of the framework

## Visual Studio

Visual Studio is Microsoft's main tool for building applications using their languages and frameworks. This IDE provides all the things a developer can need and more. It is one of the best tools for building applications with C#. It has templates for different projects, which are already built start-up projects. It helps out by underlining code that will not work or giving suggestions on what might solve some issues. It has a full debugging tool-set which means that finding bugs and problems is much easier. It also makes building, compiling, and running code very easy and fast

## Console Application

Console applications are applications that run in the console of the machine. They can be executed on the native console in Command Prompt or Power Shell if you are using windows. This is the perfect type of application to start with learning C# because it isolates the language in a very simple environment and the focus is always on the language. In later subjects when we are familiar with C#, we will definitely use different types of applications. The basic structure of the console app is this:

```csharp
// .NET console app pre .NET6
using System; 

namespace  Calculator 
{ 
  class  Program 
  { 
    static void Main(string[] args) 
    { 
      // Your code goes here
    } 
  } 
}
```

The Console App template has been simplified massively starting from .NET 6 version and above, and it basically ditched all the boilerplate and is just left with the space that previously was in the static void Main block. This does not mean that there is nothing in the background, but it is greatly simplified for us developers

```csharp
// .NET 6+ Console App
using System; 

// Your code goes here
```

## Class Library

The class library project is a special project that is made for storing and using classes. This project can't be the main running project since it is not made for running but storing classes. When we want to use classes from class libraries in other projects we need to remember to:

* Add a reference to that class library project to the current project
  * You can't have two projects referencing each other
* Add a using statement above in the document where you are writing your code to access the class from the class library  


## Methods, Strings, and DateTime 

### Methods

Methods in C# are basic functions. They are called methods because everything we do in C# is contained in some classes ( More on this in later classes ). The benefits of functions and methods are universal, so as in other languages, in C# methods are very useful for organizing the code, reusing, and decoupling code. The difference is strictly typed languages is that methods require a bit more oversight before writing them. When writing a C# method, there needs to be a data type of the return value provided, a name, and a data type of the parameters provided as well. So everything has a data type, even the return ( we have to calculate what we will return at the end ). If we don't want to return anything we can just write void, meaning that the function returns nothing. This is how a method in a console application is written:

```csharp
// The type before the name is the return type
// public and static will be discussed in next classes
public static string SayHello(string name){
  string result = $"Hello there {name}!";
  return result;
}
// Void function that does not return anything
public static void SayBye(){
  Console.WriteLine("Byeeeee!");
}
```

### Strings

Working with strings in C# can be done in different shapes and forms. There is only one way to write a string and that is with " " but there are multiple ways they can be formatted. This can be done by:

#### String building

```csharp
string hello1 = "Hello " + name;
string hello2 = string.Format("Hello {0}", name);
string hello3 = $"Hello {name}";
```

#### String formating

```csharp
// Currency formating
string currency = string.Format("{0:C}", 125.45); 
// Percent formating
string percent = string.Format("{0:P}", .5); 
// Custom formating
string customFormat = string.Format("{0:0##-###-###}", 078270396); 
// Alignment formatting
string customAlignment = string.Format("| {0,10} | {1,10} |", "Id", "Order"); 
```

#### String methods

```csharp
string ourString = "   We are learning C# and it is FUN and EASY. Okay, maybe just FUN.    ";
Console.WriteLine(ourString);

// Makes our string Upper/Lower Case
string lowe = ourString.ToLower();
Console.WriteLine(lowe);
string upper = ourString.ToUpper();
Console.WriteLine(upper);

// Prints the length of our string
int ourLength = ourString.Length;
Console.WriteLine(ourLength);

// Splits the string and makes an array of strings (splits on character selected)
string[] splited = ourString.Split('.');
Console.WriteLine(splited[0]);
Console.WriteLine(splited[1]);
Console.WriteLine(splited[2]);
// The line below is commented because there is no index 3 in our splited array
//Console.WriteLine(splited[3]);

// Checks if a string starts with some string given and returns true or false
bool startsWith = ourString.StartsWith("   W");
Console.WriteLine(startsWith);

// Checks if a string exists and if so returns an index, if not -1
int indexOfString = ourString.IndexOf("FUN");
int nonExistingString = ourString.IndexOf("Nope");
Console.WriteLine(indexOfString);
Console.WriteLine(nonExistingString);

// Cuts the string in to a substring that starts from index 5 and takes the next 16 characters
string substring = ourString.Substring(5, 16);
Console.WriteLine(substring);

// Creates an array of characters with every character from our string
char[] chars = ourString.ToCharArray();
Console.WriteLine(chars.Length);
Console.WriteLine(chars[6]);
// Two ways to turn char[] back to string
Console.WriteLine(string.Join("", chars));
Console.WriteLine(new string(chars));

// It trims the white spaces at the front and back of the string
string trimmedString = ourString.Trim();
Console.WriteLine(trimmedString);
```

### DateTime

DateTime is a complex type in C# representing the date and the time at a particular moment. This complex type can be edited, manipulated, and used every time we need to store dates or time and change or use it easily.

#### Creating DateTime

```csharp
DateTime aDate = new DateTime(); // Creating a new empty date
DateTime aCustomDate = new DateTime(1992, 10, 15); // Creating a custom date
DateTime currentDay = DateTime.Today; // Getting todays date without time
DateTime currentDateTime = DateTime.Now; // Getting todays date with time
```

#### Converting and formating a string

```csharp
string dateFormat1 = DateTime.Now.ToString("MM/dd/yyyy"); // Formating date to string
string dateFormat2 = DateTime.Now.ToString("dddd, dd MMMM yyyy"); // Formating date to string
string stringDate = "12-15-2012"; 
DateTime convertedDate = DateTime.Parse(stringDate); // Converting string to date
```

#### Manipulating DateTime

```csharp
DateTime  currentDateTime  =  DateTime.Now;

// Adding or removing days to a DateTime date
DateTime addedDays = currentDateTime.AddDays(2);
Console.WriteLine(addedDays);
DateTime removedDays = currentDateTime.AddDays(-5);
Console.WriteLine(removedDays);

// Adding months to a DateTime date
DateTime addedMonths = currentDateTime.AddMonths(2);
Console.WriteLine(addedMonths);

// Adding years to a DateTime date
DateTime addedYears = currentDateTime.AddYears(2);
Console.WriteLine(addedYears);

// Adding hours to a DateTime date
DateTime addedHours = currentDateTime.AddHours(3);
Console.WriteLine(addedHours);

// Get the number of the month from a DateTime
int month = currentDateTime.Month;
Console.WriteLine(month);

// Get the number of the day from a DateTime
int day = currentDateTime.Day;
Console.WriteLine(day);

// Get the number of the year from a DateTime
int year = currentDateTime.Year;
Console.WriteLine(year);
```


## Classes, Constructors and Access Modifiers 

### Classes

Classes are the backbone of every object-oriented language. As we mentioned before classes are a building block of all object-oriented applications. Classes are independent and inside them, they hold methods and properties that are unique to them. When an application starts all of these classes work together to create a whole application. A class is not a normal entity. You can’t print a class or write a class. Classes are just templates that are used to build objects with the same functionalities that we are going to give the class to have. So if a class has a property name every object that is created from that class will have a property name as well. With these classes, we can create a network of entities and concepts that build our business logic and with that, use object-oriented programming

#### Class-based Inheritance

Inheritance is one of the main concepts of object-oriented programming. It is used to connect and link entities that have some hierarchical relation to one another. It can be used to link business logic as well as reuse and organize code. Class-based inheritance means that the inheriting is abstract and that it is done on a class level. Classes inherit from other classes and when an object is created, it has the properties and methods of all the classes in the chain. C# Classes can inherit only from 1 class at a time.

### Constructors

A huge role in C# classes plays the constructors. Constructor is a method that is executed when an object is created from a class. Constructors in C# classes are written as methods but they don't have any return value and their name is always the same as the class name. The only thing that we can manipulate in a constructor is the parameters. Constructors in C# classes can have multiple constructors, and depending on how we create a class, we get a different execution of a constructor. This always depends on the parameters

```csharp
public class Person
{
  public string Name {get;set;}
  public string Age {get;set;}
  private long AccountNumber {get;set;}
  // Parametarless constructor ( new Person() )
  public Person(){
    AccountNumber = 34235432452;
  }
  // Constructor with parameters ( new Person("Bob", 34) )
  public Person(string name, int age)
  {
    Name = name;
    Age = age;
    AccountNumber = 25325325221;
  }
  public void Talk(string text){
    Console.WriteLine($"Human {Name} is saying {text}");
  }
}
```

#### Constructing object from the constructor with parameters

```csharp
// Using the first constructor
Person George = new Person();
// Using the second constructor
Person bill = new Person("Bill", 25);
bill.Talk();
```

### Access Modifiers

Access modifiers are keywords that are used to set who can and can not use your property, method, or class. These modifiers can span from use only in the class, to use only in a project to use anywhere where there is a reference to the class. We always add them in the code to tell the program where they can be accessed. If for some reason we don't add an access modifier for most entities, by default they become private. The most common access modifiers are:

* public - Can be accessed anywhere where there is a reference
* private - Can be accessed only in the class itself, not outside
* protected - Can be accessed only in the class itself, or classes derived from it
* internal - Can be accessed only in the project our class is in

## Enums 

Enumerations are sort of like a collection of values that are fixed. When it is created it is done so with the idea in mind that the values will never change and while the application is running it is impossible to add or remove an enumeration value. That is why they are usually used for common things that don't change like, names of the days of the week, names of months, names of continents, statuses from servers, etc.

```csharp
public enum Days 
{
  Monday,
  Tuesday,
  Wednesday,
  Thursday,
  Friday,
  Saturday,
  Sunday
}
```

## Collection Types and LINQ 

### Different types of collections

Using collections is not always "one fits all" scenario. In C# this is very well addressed and there are multiple types of collections that we can use to fit our needs. Most of them are generic collections, meaning that we need to provide the type in special brackets like these < >. These generic methods also use different methods for manipulation from the arrays. Some of those are:

* List - A collection that is flexible, accepts as many items, and is indexed
* Queue - A collection that is not indexed, accepts as many items, but has a special order of how the items are added or taken out of the collection ( First in is the first one out )
* Stack - A collection that is not indexed, accepts as many items, but has a special order of how the items are added or taken out of the collection ( Last in is the first one out )
* Dictionary - A collection that is flexible, accepts as many items, and only keeps data in key-value pairs

#### List

```csharp
// Create an empty list of strings
List<string> names = new List<string>();
// Add stuff to the list
names.Add("Bob");
names.Add("Midge");
names.Add("Red");
// Remove stuff from the list
names.Remove("Red");
// Find stuff from the list
names.Find("Midge");
// Number of elements
names.Count;
// Create and initialize a list of numbers
List<int> numbers = new List<int>(){ 2,89,4,8,6 };
```

### LINQ

LINQ is a component of the .NET framework that helps in writing queries for certain data. These queries can be very complex and very specific. With LINQ this can be made simpler and quicker. These queries are done by chaining methods and working with some collections. The LINQ methods always work with IEnumerable collections, meaning that they always return a very generic collection and work with a very generic and basic collection. It is up to us to convert it to our preferred collection later.

```csharp
List<string> strings = new List<string>(){"bob","midge","Red","Kitty","Fez"};
// Where
List<strings> threeLetterNames = strings.Where(x => x.Length == 3).ToList();
// Select
List<int> numberOfLetters = strings.Select(x => x.Length).ToList();
// First item
numberOfLetters.First();
numberOfLetters.FirstOrDefault();
// Last item
numberOfLetters.Last();
numberOfLetters.LastOrDefault();
```








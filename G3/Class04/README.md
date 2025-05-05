# Generics and Extension methods 🥪

## Generics 🔹

As we know, C# is a strictly typed language and when we are building applications, it is important that we use and plan the types of our data. But as you can imagine this can limit us sometimes, since there can be some business logic that requires multiple types to be accepted or to have the same logic for many different types. That is where generics come into play. Basically, we can have methods or classes that can use a placeholder type when they are declared and use different types in different scenarios, depending on the use case scenario. There is a convention in C# for writing these placeholder types and that is with the letter **T**. This can be any letter or word but T is the convention. Classes and methods are marked as generic with the < > brackets, inside which we write the place holder on declaration and the type we want to use on instantiation.

### Generic methods

Generic methods work exactly the same as standard methods but have one extra feature. That is a generic type. The generic type can represent any type or it can represent a range of types in an inheritance tree. Generic methods can be used to implement the logic for multiple types, skipping the process of creating multiple separate methods for each type.

#### Non generic example

```csharp
public void GoThroughStrings(List<string> strings)
{
    foreach (string str in strings)
    {
        Console.WriteLine(str);
    }
}
public void GoThroughInts(List<int> ints)
{
    foreach (int num in ints)
    {
        Console.WriteLine(num);
    }
}
```

```csharp
List<int> ints = new List<int>() { 1, 3, 5, 7 };
List<string> strings = new List<string>() { "Bob", "Jill", "Greg" };
GoThroughStrings(strings);
GoThroughInts(ints);
```

#### Generic example

```csharp
public static void GoThrough<T>(List<T> items)
{
    foreach (T item in items)
    {
        Console.WriteLine(item);
    }
}
```

```csharp
List<int> ints = new List<int>() { 1, 3, 5, 7 };
List<string> strings = new List<string>() { "Bob", "Jill", "Greg" };
GoThrough(strings);
GoThrough(ints);
```

### Generic classes

Generic classes share the idea of generic code and they also have a generic type that can serve as a placeholder when the class is declared. When we need to create a new instance of the class we must provide what type will replace the generic placeholder - T. Generic classes are great because when we set the whole class as generic, we can use the generic type throughout the class methods and properties without stating that those methods are generic. Generic classes are often used for building generic services or service-like structures that can do actions such as CRUD ( Create, Read, Update, Delete ) without needing to do the same logic for every entity in our code. That way we can have one centralized logic for manipulating data for almost all our types. This makes our application easily maintainable and scalable.

```csharp
public class GenericListHelper<T>
{
    public static void GoThrough(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
    public static void GetInfo(List<T> items)
    {
        T first = items[0];
        Console.WriteLine($"This list has {items.Count} members and is of type {items.GetType().FullName}!");
    }
}
```

```csharp
List<int> ints = new List<int>() { 1, 3, 5, 7 };
List<bool> bools = new List<bool>() { true, false, true, true };

GenericListHelper<int> intHelper = new GenericListHelper<int>();
GenericListHelper<bool> boolHelper = new GenericListHelper<bool>();

intHelper.GetInfo(ints);
boolHelper.GetInfo(bools);
```

### Using generics within a certain scope

Generic classes and methods can also be used in a certain scope. This means that just certain types can replace the generic type T. The scope is defined by the inheritance tree of the type we use to create this limitation. With that, all classes that are derived from that class can replace T. This also means that T in the class or method will have all the properties and methods of that class, because we know those exist on all derived classes.

```csharp
public abstract class BaseEntity
{
  public int Id { get; set; }
  public abstract string GetInfo();
}

public class Order : BaseEntity
{
  public string Receiver { get; set; }
  public string Address { get; set; }

  public override string GetInfo()
  {
    return $"{Id}) {Receiver} - {Address}";
  }
}

public class Product : BaseEntity
{
  public string Title { get; set; }
  public string Description { get; set; }
  
  public override string GetInfo()
  {
    return $"{Id}) {Title} - {Description}";
  }
}
```

#### Generic method

```csharp
public void PrintAll<T>(List<T> list) where T : BaseEntity
{
  foreach (T item in list)
  {
    // We can call GetInfo on T because T knows GetInfo exist on any type that will be passed
    Console.WriteLine(item.GetInfo());
  }
}
```

```csharp
List<Order> orders = new List<Order>() { ... orders ... };
List<Product> products = new List<Order>() { ... products ... };

PrintAll(orders);
PrintAll(products);
```

#### Generic class

```csharp
public class GenericDb<T> where T : BaseEntity
{
  private List<T> Db;
  public GenericDb()
  {
    Db = new List<T>();
  }
  public void PrintAll()
  {
    foreach (T item in Db)
    {
      Console.WriteLine(item.GetInfo());
    }
  }
  public void Insert(T item)
  {
    Db.Add(item);
    Console.WriteLine($"Item was added in the {item.GetType().Name} Db!");
  }
}
```

```csharp
GenericDb<Order> orderDb = new GenericDb<Order>();
GenericDb<Product> productDb = new GenericDb<Product>();

OrderDb.Insert(new Order() { Id = 1, Address = "Bob street 29", Receiver = "Bob" });
ProductDb.Insert(new Product() { Id = 1, Description = "For gaming", Title = "Mouse" });

Console.WriteLine("Orders:");
OrderDb.PrintAll();
Console.WriteLine("Produts:");
ProductDb.PrintAll();
```

## Extension methods 🔹

Extension methods are one of the most interesting methods you can use in C#. They are basically methods that can be called from a type, as they were part of that type. This means that we can write methods that can be called from primitive types such as String, Int, Bool, etc. We can also create extension methods for types that are provided from the .NET framework or provided from a different library. We can basically use it to attach a method that is not part of a type, to that type as if it was. These methods are amazing if we need some special logic to be executed frequently on some type, without declaring a new instance of a service class or searching for the method name of a specific method for that logic.

### How to use them

Extension methods must be created in a static class and must be static ( Since we want them to be accessible from anywhere ). They also have some special rules for the parameters. In order to attach the extension method to a type, we must type as a first parameter the keyword **this**, after that the type that we want to attach the extension method to and the name of the parameter so we can use it in the implementation of the method. Since this method will be called on the type itself directly, this first parameter is filled with the value of the type we call the method itself. So if we have an extension method with only the first parameter, that extension method will not require any parameters when it is called. If we add a second parameter, that would be the first parameter when we call the method, etc.

```csharp
public static class StringHelper
{
    public static string Shorten(this string str, int numberOfWords)
    {
        if (numberOfWords < 0)
            throw new ArgumentException("numberOfWords should be greater or equal to 0.");

        if (str.Length == 0)
            return "";

        string[] words = str.Split(' ');

        if (words.Length < numberOfWords)
            return str;

        List<string> substring = words.Take(numberOfWords).ToList();

        string result = string.Join(" ", substring);

        return result + "...";
    }

    public static string QuoteString(this string text)
    {
        return '"' + text + '"';
    }
}
```

```csharp
string bobSong = "Heeey, this is the Bob song. Yea. Bob song. It is really awesome! Extra words, extra words!";
bob.shorten(4);
```

### Piggybacking

Extension methods can be used anywhere, but on one condition: That we have the namespace included in that document. If the extension method is used in multiple places and we don't want to add everywhere a new use for the extension method itself, we can change the namespace to the extension method class to some namespace that is already used on most of the places where we need the extension method. We can use the namespace of the project itself, or we can even use a namespace to some .NET internal library such as System. This practice is called Piggybacking.

#### Using System namespace

```csharp
namespace System
{
  public static class StringHelper
  {
    public static string Shorten(this string str, int numberOfWords)
    {
      // Code
    }
    public static string QuoteString(this string text)
    {
      // Code
    }
  }
}
```

## Extra Materials 📘

* [Microsoft - Generics](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/)
* [Microsoft - Extension Methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)
* [Dot net perls on Extension methods](https://www.dotnetperls.com/extension)
* [Dot net perls on Generics](https://www.dotnetperls.com/generic)
* [Extension methods for building fluent code](https://killalldefects.com/2020/01/18/using-extension-methods-in-c-to-build-fluent-code/)

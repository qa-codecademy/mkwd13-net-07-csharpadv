# Abstract Classes and Interfaces 🍕

Since C# is an object-oriented language, it was built with classes and objects in mind and they are the main building blocks that we can use to build applications. That is why there are a lot of different keywords that are used for specializing classes for a particular purpose as well as different entities that are not classes, but support and build upon classes. With all these features, an ecosystem is created where it is easier to develop object-oriented applications, structure and organize them.

## Abstract Classes 🔹

### Why we need it

When using object-oriented programming to translate some business logic concept, there are situations where we need a class that exists in our logic to support other concepts, but has very little meaning by itself. Usually, a class like this represents some base or core idea that other ideas can easily implement on, getting the name base classes. An example would be a Company App with a Human class that implements Employee and Manager classes. We need Employees and Managers, they share a lot of human behavior and properties, so we add the Human class as a parent, but the Human class only exists to support the other classes.

### What is it

In C# there is a special class that can make cases like these easier to implement. It's called an Abstract Class. Abstract classes are classes that can have an implementation, they can have methods, properties, constructors but they can't be instantiated. This means that we can't create a new instance out of the class with the new keyword. Now the question is, how can we use it then? Well, we can inherit from it and use it as a base class for our other classes,  without the risk of someone creating a class from it, that makes little sense. Abstract classes can also have abstract members.

#### Abstract class with abstract member

```csharp
public abstract class Human
{
  public string FullName { get; set; }
  public int Age { get; set; }
  public long Phone { get; set; }
  // Abstract method, will require the child class to provide implementation
  public abstract string GetInfo();
  public Human(string fullname, int age, long phone)
  {
    FullName = fullname;
    Age = age;
    Phone = phone;
  }
  // Not abstract method will be inherited as is
  public void Greet(string name)
  {
    Console.WriteLine($"Hey there {name}! My name is {FullName}!");
  }
}
```

#### Standard class implementing the abstract one

```csharp
public class Developer : Human
{
  public List<string> ProgrammingLanguages { get; set; } = new List<string>();
  public int YearsExperience { get; set; }
  public void Code()
  {
    Console.WriteLine("tak tak tak...");
    Console.WriteLine("*Opens Stack Overflow...");
    Console.WriteLine("tak tak tak tak tak...");
  }

  public Developer(string fullname, int age, long phone, List<string> languages, int experience ) 
    : base(fullname, age, phone)
  {
    ProgrammingLanguages = languages;
    YearsExperience = experience;
  }
  public override string GetInfo()
  {
    return $"{FullName} ({Age}) - {YearsExperience} years of experience!";
  }
}
```

#### Instances from abstract and standard that implements an abstract one

```csharp
// Will not compile and show error
Human person = new Human(); 
// Will compile since it just inherits from the abstract
Developer dev = new Developer("Bob Bobsky", 44, 38970070070, new List<string>() { "JavaScript", "C#", "HTML", "CSS" }, 6); 
```

### Features and comparison

Abstract classes can be inherited from, but not instantiated which is the main feature of this type of class. Like standard classes, they can have properties and methods with implementation, that will be inherited and used in the child classes later as is. But there is another type of member that we can use in abstract classes, and those are abstract members. Abstract members are members that we know we are going to need in the child classes, but we don't give out the implementation. With abstract members, we decide that all the child classes will have the method but they need to give implementation themselves. This can be used when we have a method that we know we are going to need on all child classes, but the implementation differs for each and every one of them.  

### Abstract class vs Standard class

| **Feature**                        | **Abstract Class** | **Standard Class** |
|------------------------------------|--------------------|--------------------|
| Constructors                       | Yes                | Yes                |
| Instantiation                      | No                 | Yes                |
| Method implementation              | Yes                | Yes                |
| Members without implementation     | Yes                | No                 |
| Inheritance                        | Yes                | Yes                |
| Multiple Inheritance               | No                 | No                 |
| Access Modifiers                   | Yes                | Yes                |

## Interfaces 🔹

When we talk about an abstract class we basically create an abstraction that will help us manage our standard classes better. But there is another form of abstraction in C# that can abstract our concepts even further. It's called Interface and it is not a type of class. It is an entity on its own. This entity is very different from a class because it is not holding any implementation whatsoever. This means that even if we wanted to, we can't tell this interface how to work and what to do. So now this might be a little bit confusing. Why do we have an entity that can't hold implementation? Doesn't this make it useless? Well, this entity is exactly what we need if we want to constrain classes to certain rules as well as work with all types that follow a certain rule set. Even tho we can't use the implementation in interfaces, we can use them to inherit from. When we inherit from an interface WE MUST implement the members that the interface holds. It is like a schematic that we MUST follow when building a class if we want to implement a certain interface. If the interface has 3 methods, the class must have those 3 methods and implement them. We can also inherit from as many interfaces as we need, unlike classes from which we can inherit only once.

### Where are they used

Interfaces are used to set rules for classes. These rule sets can mix and match, having multiple rule sets apply to one class, or one rule set that applies to multiple classes at once. With this, our code can be more modular and organized and other developers can implement new classes easily. They are also used as a filter or placeholder for a type that needs to be acquired later. When we use the interface as a type, the interface will accept any object that implements that interface. This can be very useful since we can have multiple objects implementing that interface and all of them will be eligible to be used in our logic without us worrying which one is it. The interface has certain members that must be implemented and it will let any object pass that inherits the interface itself because IT IS SURE that those members are implemented. If they are not implemented, we would not be able to compile our code.

#### Interfaces

```csharp
public interface IDeveloper
{
  // Anyone who implements this interface must have a Code() method that does not return anything
  void Code();
}
public interface ITester
{
  // Anyone who implements this interface must have a TestFeature() method that does not return anything and has a string parameter
  void TestFeature(string feature);
}
```

#### Inheriting from interfaces

```csharp
// Must have GetInfo from the abstract class Human, Code from IDeveloper, and TestFeature from ITester
public class QAEngineer : Human, IDeveloper, ITester
{
  public List<string> TestingFrameworks { get; set; }
  public void Code()
  {
    Console.WriteLine("tak tak tak...");
    Console.WriteLine("Open StackEchange SQA...");
    Console.WriteLine("tak tak tak tak tak...");
  }
  public QAEngineer(string fullname, int age, long phone, List<string> frameworks)
    : base(fullname, age, phone)
  {
    TestingFrameworks = frameworks;
  }
  public override string GetInfo()
  {
    return $"{FullName} ({Age}) - Knows {(TestingFrameworks.Count != 0 ? TestingFrameworks[0] : "unknown")} testing frameworks!";
  }

  public void TestFeature(string feature)
  {
    Console.WriteLine("Run Unit Tests...");
    Console.WriteLine("Run Automated Tests...");
    Console.WriteLine($"Tests for the {feature} feature are done!");
  }
}
```

#### Using interface as parameter

```csharp
// SETUP
public interface IHuman
{
  string GetInfo();
  void Greet(string name);
}
public abstract class Human : IHuman
{
... implementation ...
}
public class Developer : Human, IDeveloper
{
... implementation ...
}
public class Tester : Human, ITester
{
... implementation ...
}
```

```csharp
// IHuman makes sure that the GetInfo() method will be implemented
// Anyone who implements IHuman in their chain can be accepted here
public void HappyBirthday(IHuman person)
{
    Console.WriteLine($"This is {person.GetInfo()}!");
    Console.WriteLine("Happy birthday! We are glad that you are part of this company!");
}
```

```csharp
Developer dev = new Developer("Bob Bobsky", 44, 38970070070, new List<string>() { "JavaScript", "C#", "HTML", "CSS" }, 6);
Tester tester = new Tester("Jill Wayne", 32, 38971071071, 560);

HappyBirthday(dev); // Will call GetInfo() implementation from Developer
HappyBirthday(tester); // Will call GetInfo() implementation from Tester
```

### Interface vs Abstract class

| Feature                        | Interface | Abstract Class |
|--------------------------------|-----------|----------------|
| Constructors                   | No        | Yes            |
| Instantiation                  | No        | No             |
| Method implementation          | No        | Yes            |
| Members without implementation | Yes       | Yes            |
| Inheritance                    | Yes       | Yes            |
| Multiple Inheritance           | Yes       | No             |
| Access Modifiers               | No        | Yes            |

# Boxing vs Unboxing

Boxing and Unboxing are processes in C# used to convert between value types (like `int`, `double`, etc.) and reference types (`object`).

## Boxing

Boxing is the process of converting a value type (such as `int`) to a reference type (such as `object`). All value types in C# derive from `object`, which is why any value type can be boxed.

### Example:
```csharp
int number1 = 9000;
object obj1 = number1;
Console.WriteLine(obj1); // Output: 9000
```

## Unboxing

Unboxing is the process of converting an object (that was previously boxed) back to a value type. Since an object can hold any type, it is possible to cast it back to its original value type.

### Example:
```csharp
object obj2 = 9000;
int number2 = (int)obj2;
Console.WriteLine(number2); // Output: 9000
Console.ReadLine();
```

## Notes
- **Casting** changes the type, but does **not** change the value of the object.
- **Converting** attempts to change the value to match the new type.
- Casting works only if the value is eligible to exist in the new type.

## Extra Materials 📘

* [Microsoft - Abstract keyword](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)
* [Microsoft - Interfaces](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/)
* [Abstract classes with examples](https://www.guru99.com/c-sharp-abstract-class.html)
* [Interface or Abstract Class](https://medium.com/@suhas_chatekar/interfaces-or-abstract-classes-bce12dce97e)
* [Implementing multiple interfaces](https://medium.com/swlh/implementing-multiple-interfaces-per-class-438da4092242)

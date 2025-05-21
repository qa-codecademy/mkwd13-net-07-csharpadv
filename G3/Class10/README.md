# Disposing and Managing Resources 🍣

## Managing resources🔹

When we are building applications with the C# language, the chances are that we are also doing that in tight collaboration with the .NET framework. This is a unique and powerful combination of syntax, features, libraries, and systems that cooperate in the background to serve and manage our application. One of the things that the .NET Framework does for us, manage its own resources. This means that when we use the classes, methods, and systems from the .NET Framework, it works in the background to track what is used and removes instances that we are not going to use. These resources that are in the scope of the .NET Framework and that are managed automatically are called managed resources. But we don't always work exclusively with the .NET Framework and its features. Sometimes we need some external resources. This can be a connection to the file system, to a database, to some other server or API, services, etc. These resources are outside of the .NET Framework scope and are not managed automatically. that is why we need to manage them ourselves. These are called unmanaged resources.

## Introduction to memory usage

When we are programming and writing code, that code has to be stored somewhere in the memory. This means that it has to take up space somewhere. Since there are different types of entities with different complexity and structure, the code that we write is divided into the Heap and Stack.

### Stack

The stack is the memory where we can allocate things that are static. Since the things we store here are static, they are saved directly, and retrieving stored data is very fast. In the stack, we can keep value types such as variables with integers, strings, booleans, etc. The stack also houses all the references to complex types such as instances of classes. This does not mean that it holds the whole instance and the data of the class, it just means that it remembers the address of where the class instance is stored so it can point to it when somebody requests to use it. The stack also tracks the order of the memory allocated ( Last In First Out ) so all the things that enter the stack are used in the reverse order in which they were added.

![StackVsHeap1](img/HeapStack1.png)

### Heap

The heap is the dynamic part of the memory, where we keep the complex types of data such as class instances themselves. This memory is allocated at runtime, meaning that it is a bit slower. Unlike the stack, the heap has no particular order and we can access and use any entity in the heap at any time. With that said, allocating memory here can be done at any time and that memory can be cleared at any time. As we said, we store the instances of classes ( objects ) in the heap. When a new instance is created, the memory is allocated in the heap and the data for that object is stored. In the stack, an address pointing to that memory location is saved. When we call that address it points to the object in the heap and we can access it, change it. Luckily we don't have to constantly worry about the heap since the .NET Framework manages most of the heap automatically.

![StackVsHeap2](img/HeapStack2.png)

### A C# Object life cycle

![Object life cycle](img/Lifecycle.jpg)

## Disposable🔹

We mentioned that throughout our development process we can encounter some resources that are not managed automatically. Those unmanaged resources need to be managed manually. The process of releasing those resources that we allocated is called disposing or disposable. Unmanaged resources can lead to slow application, running out of available resources, and even blocking our application. The classes that support this system of disposing of always inherit from the IDisposable interface. In the .NET Framework, classes that work with an outside source are always classes that can be disposed of.

### Disposing manually

Let's say that we want to create a connection to some file and work with it. When we are done we need to close the connection. But there are a few issues with this code. The first and most obvious is that we have to remember to write the Dispose() method. If we don't this connection will hang as long as our application is running. Another thing is that we can exit our method before the Dispose() is even called. This can happen if we return something in a scenario before we get to Dispose() or simply have an exception at some point before we get to the Dispose() method. These scenarios need to be taken into consideration when we use this approach in handling unmanaged resources.

#### Manual disposing

```csharp
public void AppendTextInFile(string text, string path)
{
  StreamWriter sw = new StreamWriter(path, true);
  // If something were to happen here, the class will not get disposed along with this connection to the file system
  if (text == "break") throw new Exception("Something broke unexpectedly...");
  sw.WriteLine(text);
  sw.Dispose(); // We dispose here manually
}
```

### Disposing of with Using Block

There is a feature in C# that allows us to automatically call a Dispose() method when a code block finishes with execution. No matter what happens in our code block, when it is done, the Dispose() method will be called. This is done with the Using block. We can write a using block and inside create an instance of a disposable class. The instance of that class is only available in that block of code and only when the block is done under any circumstance, the Dispose() will get called automatically. This helps us in multiple ways. We are sure that we will dispose of the class properly and we also scope the instance of the disposable class in the context where we want to use it.

#### Disposing with the Using Block

```csharp
public void AppendTextInFileSafe(string text, string path)
{
  using (StreamWriter sw = new StreamWriter(path, true))
 {
    if (text == "break") throw new Exception("Something broke unexpectedly...");
    sw.WriteLine(text);
  } // After this block the class will dispose it self no matter what happens
}
```

## Building a disposable class 🔹

The disposable classes from the .NET Framework aside, we can also use the IDisposable interface to build our own disposable classes with our own implementation for the Dispose() method. In the Dispose() method we can implement closing connections, resetting values, and all things necessary.

### Custom disposable class

```csharp
public class OurWriter : IDisposable
{
    private string path;
    private StreamWriter _sw;
    private bool disposedValue = false;

    public OurWriter(string filePath)
    {
           path = filePath;
           _sw = new StreamWriter(path, true);
    }
    public void Write(string text)
    {
        if (text == "break") throw new Exception("Something broke unexpectedly...");
        _sw.WriteLine(text);
    }

    // We implement this private method that will remember when this class is disposed
    // That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
    private void _dispose(bool disposing)
    {
        // This happens only when the class needs to be disposed of the first time
        if (!disposedValue)
        {
            if (disposing)
            {
                _sw.Dispose();
            }

            path = "";
            disposedValue = true;
        }
    }
    // We can implement this method alone and add the disposing here
    public void Dispose()
    {
        _dispose(true);
    }
}
```

## Nullable values 🔹

In C# all values must have a type, which is something that we already established. The types can be value and reference types. Value types are usually primitive types such as integer or boolean. Reference types point to some complex entity such as an object. When objects are empty they hold the value of null, meaning that there is nothing there. That is the default value of any object. But value types hold a default value from their context, meaning that their default value resembles a normal value that can be interpreted as an intentional one. For instance, an integer has a default value of 0. This means that if we have a scoring system and somehow, a student gets an error and their score is not updated, the default value will stay 0 and that could be interpreted that the student had an error OR that the student didn't score any points. Because of this, in C# there is an option to make any value that does not accept null as a value to nullable. Nullable means that the type will accept values from its context as well as null. This can make logic much more precise and developers can implement code with fewer assumptions and special cases. Nullable is noted as a question mark after the type.

> Note: Among the primitive values, a string is nullable by design, and the? a notation will not work on it

```csharp
public class Person
{
    public int Id { get; set; }
    public int? Score { get; set; }
    public string Name { get; set; }
}

// Since we didn't add any value to this person, all values will be nullable
Person prs = new Person();
Console.WriteLine(prs.Id); // Is 0 by default
Console.WriteLine(prs.Score); // Empty result in the console
Console.WriteLine(prs.Score == null); // Is null by default
Console.WriteLine(prs.Name); // Empty result in the console
Console.WriteLine(prs.Name == null); // Is null by default

// prs.Id = null; // Throws an error. We can't put null in an int
prs.Score = null; // If it's nullable we can add null as a value
```

<br>

# Serialization/Deserializaiton🔹

We can build object-oriented C# applications with the C# structure, classes, collections, and objects. But when we need to transfer that data somewhere we run into a problem. We can't really transfer the objects as C# objects and even if we could, the other system or destination may not be able to understand the structure of the data. Therefore we need to send or save the information in some understandable format for both sides. The same goes for receiving information. That is why we need to convert our data before we can do any communicate with it.

### Serialization

Serialization is the process of converting our data that is written and structured in the C# language into a data type that can easily be sent to another system, saved somewhere, and easily understood. In our case, we can convert the data to a JSON file. Although in our case we are using C# and converting to JSON, serialization as a process is not exclusive to these types. Serialization can be done in almost any language that is used for web development and can convert into things other than JSON such as XML.

### Deserializaiton

Deserialization is the reverse process of Serialization. It converts a data type that is widely used, easily transported, and understood by many systems into a more specific and complex one. This means that with this system we can convert a data type into our native C# structure such as objects, collections, etc. So if we accept a JSON we can convert it to our native C# code, even though the code on the other side was maybe written in another language. Deserialization, as serialization is not exclusive to C# and JSON and can be used in different languages and with different data types for conversion.

### Uses

Serialization and Deserialization are very commonly used when building web applications. They are used to convert HTTP request payloads that come in and out of our applications. They can also be used for converting data into XML or JSON and storing the data on the file system. We can store configurations or some local data changes into our file system this way. Since we are not using any databases at the moment for this subject, these features can be used to even simulate a database on the file system. The database will be JSON files and we will serialize the data each time we want to read from the database and deserialize when we want to write in it. With this, there is a possibility to create a console application that can save data even when the application is closed and re-opened again.

### Manually serialize and deserialize objects

It is not easy to deserialize and serialize manually. We have to parse the string that we get, take out the important values, and map them to the correct properties. We need to do the same process in reverse as well for the deserialization. This can take a lot of effort, so there are already built libraries that do this for us.

#### Manually serialize/deserialize a Student class

```csharp
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsPartTime { get; set; }
}
```

```csharp
// Serializes only a student object 
public string SerializeStudent(Student student)
{
    string json = "{";
    json += $"\"FirstName\" : \"{student.FirstName}\",";
    json += $"\"LastName\" : \"{student.LastName}\",";
    json += $"\"Age\" : \"{student.Age}\",";
    json += $"\"IsPartTime\" : \"{student.IsPartTime.ToString().ToLower()}\"";
    json += "}";
    return json;
}

// Deserializes only student object
public Student DeserializeStudent(string json)
{
    // Cleaning the json
    string content = json
        .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
        .Replace("\r", "")
        .Replace("\n", "")
        .Replace("\"", "");
    string[] properties = content.Split(',');

    // Creating dictionary with clean keys( properties ) and values
    Dictionary<string, string> propertiesDictionary =
        new Dictionary<string, string>();
    foreach (string property in properties)
    {
        string[] pair = property.Split(':');
        propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
    }

    // Creating a Student object with the values from the dictionary
    Student student = new Student();
    student.FirstName = propertiesDictionary["FirstName"];
    student.LastName = propertiesDictionary["LastName"];
    student.Age = int.Parse(propertiesDictionary["Age"]);
    student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

    return student;
}
```

## NuGet 🔹

Package managers are a very useful tool in a developer's toolset. It helps with picking the right library, tracking the version, installing and uninstalling the library at any time. We already covered the NPM package manager for JavaScript. C# also has a package manager of its own. That is the NuGet package manager. This package manager is built in Visual Studio so that we can easily manage our packages directly from our solution and project. All we need to do is right-click on our project and go **Manage NuGet Packages**. There we can see all the installed packages, their versions and we can browse through new packages and install them with one click.

## Newtonsoft.Json 🔹

One of the most famous libraries for serialization and deserialization in C# is the Newtonsoft.Json library. We can add it from the NuGet package manager to our project very easily. This library gives us the option to automatically serialize and deserialize stuff without much configuration and settings. We can even configure the properties, their mapping as well as what happens when an object is serialized or deserialized.

### Serialization Example

```csharp
Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 40,
    IsPartTime = false
};
string bobSerialized = JsonConvert.SerializeObject(bob);
```

### Deserialization Example

```csharp
Student bobDeserialized = JsonConvert.DeserializeObject<Student>(bobSerialized);
```


## Extra Materials 📘

* [Stack and Heap in .NET in depth](https://www.c-sharpcorner.com/article/C-Sharp-heaping-vs-stacking-in-net-part-i/)
* [All About IDisposable](https://gunnarpeipman.com/csharp-idisposable/)
* [Microsoft - Cleaning unmanaged resources](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged)
* [Implementing Disposable Classes in depth](https://www.codeproject.com/Articles/15360/Implementing-IDisposable-and-the-Dispose-Pattern-P)
* [Microsoft - Named and Optional arguments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments)
* [Microsoft - Serialization](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization)
* [Newtonsoft.Json Documentation](https://www.newtonsoft.com/json/help/html/Introduction.htm)
* [Channel9 - Learn Nuget](https://channel9.msdn.com/Series/NuGet-101/?&WT.mc_id=EducationalNuget-c9-niner)

# C# Conventions, Practices, and Principles

## Good Practices 🚀

In C# as in any other language, there are some Good Practices or Invisible Rules that we need to follow for our code to be better, more efficient, and for the most part, better understood. Keeping up with good practices and conventions can result in scalable, readable, and easy to maintain code. Sometimes we find ourselves writing code that doesn't follow some of these practices, but we must always strive to make our code as good as we possibly can. Here are some good practices that can be used to write better C# code:

### Naming ☄

* **Variables** and **Parameters** are always written in **camelCase**
* **Classes, Methods, Properties** are written in **PascalCase**
* **Private fields** are always written with **underscore camelCase** ( ex: \_privateField )

### Properties and Fields ☄

* Use properties for values in any Class
* Avoid using fields unless they are private
* Use **private fields** to hide values and instances that are exclusive to a class and need to be hidden from the outside world
* Write **boolean names** so that they can be answered with **yes or no** ( IsDeleted, CanLogin, HasCheckedIn )
* Always add Exception suffix when creating custom Exception classes
* Always add the I prefix when writing Interfaces

### Methods ☄

* Write Service Classes and group/organize methods
* Keep methods short
* Avoid too many parameters
* If a method has too many lines of code or it has too many parameters, think about splitting it into multiple smaller methods if possible

### Loops ☄

* Use foreach whenever possible
* Don't request fixed values inside a loop, declare a variable outside with the value
* Use break if searching for a value to close the loop when data needed is found
* Counters by convention have one letter name usually: i, j, k or i, ii, iii, etc.

### If/Else statements ☄

* When writing an if statement that results in bool value in any way, don't use comparison with true or false
* Invert If statements to see if you can make else redundant
* Don't use one-liner ifs for more than one line of code
* For longer if/else statements try using a switch instead

## Programming Principles 🎯

Just like in any other craft and profession, some principles were laid over the years by professionals and the community that we can follow. These principles can serve as a foundation for good programming habits as well as a collection of rules to follow when writing and developing any kind of program. There are many principles, some more complicated than others. We are going to mention some of the most well-known.

### SOLID 🌟

Writing code and building applications are always hard. It is hard because we are not building an application to work one time, but work and scale in the future. For this reason, if the code piles in one place, it can be really hard to maintain, scale, and add new features. The SOLID principles are a compilation of principles that set up a baseline for a good, scalable, and maintainable code.

* Single Responsibility ⭐
  The single responsibility principle tackles the problems mentioned above by adding a rule that every organizational entity ( Ex: class, module, etc. ) should have one responsibility and do stuff only for that thing. This means that every functionality of our software should be separated into a new entity ( in our example classes ) and when we add new code we should add that code to the entity within that functional scope or create a new entity in which to store it. At the end of the day, there should be only one reason for changing an entity ( class ). This helps us to easily navigate through our application code and add new features easily. With this principle used, we can make our application more flexible and scalable.
* Open-Closed ⭐
  The Open-Closed principle gets its name by its two rules: Open for extension, closed for modification. This means that we need to look a bit in the future when writing our code and strive to make it generic and modular. When a new feature or changes need to be implemented in our code, we can just extend a class instead of changing some of the previously written code that worked. This by no means suggests that we never edit our classes and functions, but implies that we should avoid editing the code that already works and try and add new code that is independent as much as the situation allows us.
* Liskov Substitution ⭐
  The Liskov Substitution has a simple rule. If we have a parent class and that class has two derived classes from it, the derived classes can always substitute the parent and work correctly. We should always get the desired effect, accessing a method from a parent class with an instance of the child or accessing a parent class with an instance of its own. This in term helps with building more flexible and generic code when needed.
* Interface Segregation ⭐
  The interface segregation principle follows a simple rule. We don't want a class to implement an interface and be forced to hold a method it will not use. This can happen when we model our interfaces only by our classes and after reusing the interfaces we end up in a situation with extra methods that we never use. This is fixed with the interface segregation principle by creating interfaces for every logical scope. This way we can reuse interfaces and escape the problem of redundant methods in classes.
* Dependency Inversion ⭐
  The one thing that we need to strive for in our code is to have as much decoupled code as possible. Decoupled means that we don't want our code to be full of dependencies, we don't want all pieces of code to be dependent on one another. If we have tightly coupled code ( code full of dependencies ) and we try to change something we would quickly realize that we need to change a lot of code for that small change. This is a problem. We don't want to change tons of code for one small change and then test the whole application again because we did a lot of changes. This makes our code unreliable, hard to maintain, and hard to scale. The dependency inversion principle says that we need to abstract the dependencies that we have and ask for them from outside. This creates methods and classes that don't care about the dependency inside of their implementation. They request for an implementation of a certain abstraction and when they get it they do their job. In C# we can do that with Interfaces. We can request an interface and wait for the implementation of ANY class that implements that interface. Not only does this help us with decoupled code, but it also gives us the benefit of having flexible and scalable code.

### Other well-known principles ⚡

* DRY ( Don't Repeat Yourself )
  The DRY principle is a rule that we need to avoid and try not to repeat implementation in our code. Every piece of logic must have a single and unique representation in our code.
* YAGNI ( You Aren't Gonna Need It )
  YAGNI is a principle that is very closely connected to refactoring. It sets a rule that when coding, we need to add code when we need it, not if we think we are going to need it. Together with other principles and practices such as continuous refactoring this principle can help us build and improve our code over time.
* KISS ( Keep It Simple Stupid )
  This principle states that code works best when kept to its simplest form. Always try and find the simplest solution that could work and meet the requirements. Unnecessary complexity and features should be avoided. This makes our code more readable, understandable, and maintainable.

### Extra Resources 🎁

#### Articles

* [Solid Principles Made Easy](https://medium.com/@dhkelmendi/solid-principles-made-easy-67b1246bcdf)
* [CodeProject - C# Best Practices](https://www.codeproject.com/Articles/118853/Some-Best-Practices-for-C-Application-Developmen)
* [Microsoft Guide To Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

#### Code Maze SOLID Series

* [Single Responsibility Principle](https://code-maze.com/single-responsibility-principle/)
* [Open-Closed Principle](https://code-maze.com/open-closed-principle/)
* [Liskov Substitution Principle](https://code-maze.com/liskov-substitution-principle/)
* [Interface Segregation Principle](https://code-maze.com/interface-segregation-principle/)
* [Dependency Inversion Principle](https://code-maze.com/dependency-inversion-principle/)

#### Videos

* [Tim Corey Videos on SOLID](https://www.youtube.com/watch?v=5RwhyZnVRS8&list=PLLWMQd6PeGY3ob0Ga6vn1czFZfW6e-FLr)
* [SOLID in JavaScript in 10 min](https://www.youtube.com/watch?v=GtZtQ2VFweA)
* [Write Clean Code with Mosh](https://www.youtube.com/watch?v=5koPpYVa020)

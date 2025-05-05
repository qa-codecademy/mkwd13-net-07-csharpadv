// See https://aka.ms/new-console-template for more information
using Generics.Domain.Models;
using Generics.Entities.Data;
using Generics.Entities.Models;
using Generics.Helpers;

/*
	*GENERICS* => concept of writing code that can work with multiple types while maintaining type safety.
	
	=> Generics allow you to write classes, methods, and interfaces that can work with any data type. This promotes code reusability, as the same generic type or method can be used with different data types without needing to rewrite the code.
	
	=> Example: List<T> => T is a placeholder for any type of data
	
	=> Types of generic entities:
		1) Generic methods
		2) Generic classes
		3) Generic interfaces 

	=> Usecases:
		1) Generic Repository (Data Access) classes 
		2) Generic Service classes
		3) Generic Helper methods/classes
*/

#region Generic Methods

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n\n================ Generic Methods ================\n");
Console.ResetColor();

List<string> strings = new List<string>() { "str1", "str2", "str3" };
List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
List<bool> bools = new List<bool>() { true, false, true };

// ===> NON GENERIC METHODS EXAMPLE
NotGenericListHelper notGenericListHelper = new NotGenericListHelper();
notGenericListHelper.PrintStrings(strings);
notGenericListHelper.PrintInfoForStrings(strings);

notGenericListHelper.PrintIntegers(ints);
notGenericListHelper.PrintInfoForIntegers(ints);

// => we need new methods for bool, product, user, long, double ..... BAD !


// ===> GENERIC METHODS EXAMPLE
Console.WriteLine("\nUsing Generic Helper\n");
GenericListHelper genericListHelper = new();
//genericListHelper.PrintList<string>(ints);

genericListHelper.PrintList<string>(strings); // not necessery to explicitly write the type
genericListHelper.PrintList(ints);
genericListHelper.PrintList(bools);

GenericListHelper.PrintInfo(strings);
GenericListHelper.PrintInfo<int>(ints);
GenericListHelper.PrintInfo(bools);

List<double> doubles = new() { 123.232, 433.432 };

genericListHelper.PrintList<double>(doubles);

// => no need for new methods for different types...

#endregion


#region Generic Classes
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================ Generic Classes ================\n");
Console.ResetColor();

Product mobilePhone = new Product() { Id = 10, Title = "Mobile Phone", Description = "Mobile Phone Description" };
Console.WriteLine(mobilePhone.GetType().Name);
Console.WriteLine(mobilePhone);

GenericDb<Product> ProductsDB = new GenericDb<Product>();
ProductsDB.Insert(mobilePhone);
ProductsDB.Insert(new Product { Id = 20, Title = "Keyboard", Description = "Mechanical" });
ProductsDB.Insert(new Product { Id = 30, Title = "USB", Description = "64GB" });
List<Product> allProducts = ProductsDB.GetAll();

GenericDb<Order> OrdersDB = new GenericDb<Order>();
OrdersDB.Insert(new Order { Id = 1, Address = "Bobsky St.", Receiver = "Bob Bobsky" });
OrdersDB.Insert(new Order { Id = 2, Address = "Jill St.", Receiver = "Jill Bobsky" });
OrdersDB.Insert(new Order { Id = 3, Address = "Greg St.", Receiver = "Greg Gregsky" });
List<Order> allOrders = OrdersDB.GetAll();

ProductsDB.PrintAll();
OrdersDB.PrintAll();
#endregion


#region Using generics within a certain scope
// only classes derived from BaseEntity are allowed to use GenericDb<T>
// this is possible because we've added "where T : BaseEntity" 
// GenericDb<string> StringsDB = new GenericDb<string>();
// GenericDb<Dog> DogsDB = new GenericDb<Dog>();
#endregion

Console.ReadLine();
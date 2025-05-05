using Generics;
using Generics.Domain;
using Generics.Domain.Models;
using System.Runtime.InteropServices;

List<string> strings = new List<string>() { "Hello", "G6", "bye" };
List<int> ints = new List<int> { 1, 2, 3 };
List<bool> bools = new List<bool> { true, false };

NonGenericHelper nonGenericHelper = new NonGenericHelper();
nonGenericHelper.PrintListOfStrings(strings);
nonGenericHelper.PrintListofInts(ints);
nonGenericHelper.PrintListofBools(bools);

//here we pass on the type that will be placed in the placeholder T in genericHelper
GenericHelper<string>.PrintList(strings);
GenericHelper<int>.PrintList(ints);
GenericHelper<int>.PrintListInfo(ints);
GenericHelper<string>.PrintListInfo(strings);

//T will be replaced with product for this instance of GenericDb
GenericDb<Product> productsDb = new GenericDb<Product>();


Product product = new Product();
product.Id = 1;
product.Title = "Pizza";
product.Description = "Delicious";
productsDb.Add(product);

productsDb.Add(new Product { Id = 2, Title = "Coca cola", Description = "Drink" });

productsDb.PrintAll();

Console.WriteLine("======================================");

//T will be replaced with order for this instance of GenericDb
GenericDb<Order> ordersDb = new GenericDb<Order>();
//GenericDb<int> integers = new GenericDb<int>(); //ERROR => int does not inherit from BaseEntity

ordersDb.Add(new Order { Id = 1, OrderedBy = "Petko", Address = "Address1" });
ordersDb.PrintAll();
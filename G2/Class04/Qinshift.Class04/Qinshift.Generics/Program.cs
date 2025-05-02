

using Qinshift.Generics.Entities;
using Qinshift.Generics.Helpers;

NotGenericHelper notGenericHelper = new();

List<string> names = new List<string>() { "Martin", "Dare", "Slave", "Ana" };
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

notGenericHelper.GetInfoForStrings(names);
notGenericHelper.GoThroughStrings(names);

notGenericHelper.GetInfoForInts(numbers);
notGenericHelper.GoTroughInts(numbers);



Console.WriteLine("================ Generic Helper ================");

// If the members of the Generic class are not static then we need to 
// create an instance of that class like:

//GenericListHelper<decimal> genericListHelper = new();

List<bool> booleans = new List<bool> { true, false };


GenericListHelper<string>.GetInfoForItems(names);
GenericListHelper<int>.GetInfoForItems(numbers);
GenericListHelper<bool>.GetInfoForItems(booleans);


GenericListHelper<string>.GoThroughItems(names);
GenericListHelper<int>.GoThroughItems(numbers); 
GenericListHelper<bool>.GoThroughItems(booleans);


Console.WriteLine("============== Generic DB implementation ==============");

List<Product> products = new List<Product>()
{
    new Product() {Id = 1, Name = "Prod 1", Description = "Prod desc 1"},
    new Product() {Id = 2, Name = "Prod 2", Description = "Prod desc 2"},
};

List<Order> orders = new List<Order>
{
    new Order() {Id = 1, Receiver = "Darko", Address = "Test address 1"},
    new Order() {Id = 2, Receiver = "Slave", Address = "Test address 2"},
    new Order() {Id = 3, Receiver = "Sandra", Address = "Test address 3"},
};

GenericDb<Product> productsDb = new GenericDb<Product>();
GenericDb<Order> ordersDb = new GenericDb<Order>();

// This will not work since int or List<int> is not BaseEntity (Doesn't inherit from BaseEntity)
//GenericDb<int> numbersDb = new GenericDb<int>();
//GenericDb<List<int>> genericDb = new GenericDb<List<int>>();

productsDb.InsertRange(products);
ordersDb.InsertRange(orders);


productsDb.PrintAll();
ordersDb.PrintAll();
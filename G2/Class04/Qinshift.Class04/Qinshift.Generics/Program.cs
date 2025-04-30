

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


List<Product> products = new List<Product>()
{
    new Product() {Name = "Prod 1", Description = "Prod desc 1"},
    new Product() {Name = "Prod 2", Description = "Prod desc 2"},
};
GenericListHelper<Product>.GoThroughItems(products);
using Qinshift.ExtensionMethods.Helpers;
using Qinshift.ExtensionMethods.Entities;




string veryLongString = "This is a very long string for no reason, because I want to make it shorter!";
string test = "";


string something = "This is another string";

Console.WriteLine(veryLongString.Shorten(3));
Console.WriteLine(veryLongString.Shorten(5));

Console.WriteLine(test.Shorten(2));

//Console.WriteLine(something.Shorten(-1));



Console.WriteLine(veryLongString.QuoteString());
Console.WriteLine(something.QuoteString());


int number = 10;

if (number.IsEven())
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}



Product product1 = new Product() { Id = 1, Name = "Milk" };
Product product2 = new Product() { Id = 2, Name = "Bread" };
Product product3 = new Product() { Id = 3, Name = "Eggs" };

Console.WriteLine("Products Ids printed in conosle:");
product1.PrintProductId();
product2.PrintProductId();
product3.PrintProductId();


//PiggyBacking 

veryLongString.PiggybackingQuoteString();
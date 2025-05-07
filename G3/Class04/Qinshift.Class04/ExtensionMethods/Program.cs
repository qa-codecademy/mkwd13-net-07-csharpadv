using ExtensionMethods.Helpers;
using ExtensionMethods.Models;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n=================== EXTENSION METHODS ===================\n");
Console.ResetColor();

#region String Extensions examples
Console.WriteLine("\n============== String Extensions ==============\n");

string text = "C# Advanced is an awesome subject with great demos and activities!";
Console.WriteLine(text.ToUpper());
Console.WriteLine(text.ToLower());
Console.WriteLine(string.Join("JOIN", text.Split(' ')));
Console.WriteLine(text.Replace("awesome", "tapa"));

// Since we don't have a built-in method for shortening strings, we can create one and extend the strings functionalities with this extension method

// NOTE: Don't need to access it as a regular static class, even if it is techincally possible
// string shortenString = StringExtensions.Shorten(text, 5);
// Console.WriteLine(shortenString);

Console.WriteLine(text.Shorten(5));
// int num = 32;
// Console.WriteLine(num.sho);

string quotedString = "This is Quoted String".QuoteString();
Console.WriteLine(quotedString);
Console.WriteLine("Bla Bla bla".QuoteString());

Console.WriteLine(32.ToNumberString());
#endregion


#region List Extensions example
Console.WriteLine("\n============== List Extensions ==============\n");

List<string> strings = new() { "str1", "str2", "str3" };
//ListHelper.PrintStrings(strings);

strings.PrintStrings();

List<int> integers = new() { 3214, 34, 54, 6534543 };
integers.Print();
strings.Print();
#endregion


#region Product Extensions
Console.WriteLine("\n============== Product Extensions ==============\n");

List<Product> products = new List<Product>()
{
    new() { Id = 1, Title = "Product 1", Description = "Description 1"},
    new() { Id = 2, Title = "Product 2", Description = "Description 2"},
    new() { Id = 3, Title = "Product 3", Description = "Description 3"},
};

products.Print();
products.PrintInfo();
#endregion

using Qinshift.ExtensionMethods.Helpers;


string veryLongString = "This is a very long string for no reason, because I want to make it shorter!";
string test = "";


string something = "This is another string";

Console.WriteLine(veryLongString.Shorten(3));
Console.WriteLine(veryLongString.Shorten(5));

Console.WriteLine(test.Shorten(2));

//Console.WriteLine(something.Shorten(-1));



Console.WriteLine(veryLongString.QuoteString());
Console.WriteLine(something.QuoteString());





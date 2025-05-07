using ExtensionMethods.Helpers;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n=================== EXTENSION METHODS ===================\n");
Console.ResetColor();


#region String Extensions examples
string text = "C# Advanced is an awesome subject with great demos and activities!";
Console.WriteLine(text.ToUpper());
Console.WriteLine(text.ToLower());
Console.WriteLine(string.Join("JOIN", text.Split(' ')));
Console.WriteLine(text.Replace("awesome", "tapa"));

//  text.Shorten
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
namespace ExtensionMethods.Helpers
{
    /// <summary>
    ///  Class containing extension methods for strings
    ///  Extension methods MUST be created in a static class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Extension methods, enable you to "add" methods to existing type without creating a new derived type or otherwise modifying the original type. 
        /// Extension methods are a special kind of static methods, but they are called as if they were instance methods on the extended type.
        /// NOTE : The first parameter specifies which type we are extending (string in our example)  and the parameter is preceded by the this keyword always.
        /// In this example, method takes two parameters, string and number of words that we need to show from that string. 
        /// First we are doing some validations and preventing the user from sending a negative number or an empty string. This is a good practice in programming called "defensive programming".
        /// </summary>

        // SYNTAX: public static [return type] [name] (this [the extended type] [variable name], [additional parameters, if any])
        public static string Shorten(this string text, int numberOfWords)
        {
            // "C# Advanced is an awesome subject with great demos and activities!"
            string[] words = text.Split(' ');
            string result = string.Empty;
            for (int i = 0; i < numberOfWords; i++)
            {
                result += words[i] + " ";
            }

            return result;
        }

        /// <summary>
        /// Extension method for quoting a string. This method as a parameter
        /// takes one text of type string and we are just returning the same
        /// text but in quotes. Note again the this keyword in the first parameter..
        /// </summary>
        public static string QuoteString(this string text)
        {
            return $"\"{text}\"";
        }

        public static string ToNumberString(this int number)
        {
            return $"The number is {number}";
        }
    }
}

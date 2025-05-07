namespace ExtensionMethods.Helpers
{
    public static class StringExtensions
    {
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

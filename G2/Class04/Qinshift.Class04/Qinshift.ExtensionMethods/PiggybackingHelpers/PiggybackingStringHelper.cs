namespace Qinshift.ExtensionMethods.Helpers
{
    public static class PiggybackingStringHelper
    {
        public static string PiggybackingShorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentException("The number of words should be greater than 0");

            if (str.Length == 0)
                return "";

            string[] words = str.Split(' ');

            if (words.Length < numberOfWords)
                return str;

            List<string> substring = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", substring);

            return result + "...";
        }

        public static string PiggybackingQuoteString(this string text)
        {
            return $@"""{text}""";
        }

    }
}

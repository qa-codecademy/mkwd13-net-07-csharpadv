namespace ExtensionMethods
{
    public static class StringHelper
    {
        public static string Shorten(this string text, int numerOfWords)
        {
            //validation checks
            if(numerOfWords <= 0)
            {
                return ""; //string.Empty
            }

            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            string[] words =  text.Split(" "); //we split the text by empty spaces

            if(words.Length < numerOfWords)
            {
                //either return a message with an error or return the whole text because the user wanted ex 10 words, we have 7, it is less than 10 ( the max words that he wanted shortened)
                return text;
            }

            //Take returns IEnumerable and we can transform it toList or toArray...
            List<string> resultWords = words.Take(numerOfWords).ToList(); //Some, text, about, G6
            string result = string.Join(" ", resultWords); //Some text about G6
            return result;
        }
    }
}

using Task01.Logic.Models;

namespace Task01.Logic.Services
{
    public class TextService
    {
        public List<NameCountResult> CountNameAppearancesInText(string text, List<string> names)
        {
            //string[] wordsInText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Logical Error, we get "John." as value in the array, so we need to split the string on '.' and ',' as well
            string[] wordsInText = text.Split(new char[] {' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
            
            // Using LINQ
            List<NameCountResult> namesCountResult = names
                .Select(name => new NameCountResult
                {
                    Name = name,
                    Count = wordsInText.Count(word => word.Equals(name, StringComparison.OrdinalIgnoreCase))
                })
                .ToList();

            // Step By Step
            List<NameCountResult> namesCountResultExample = new();

            foreach (string name in names)
            {
                int nameCounter = 0;
                foreach (string word in wordsInText)
                {
                    //if (name.ToLower() == word.ToLower())
                    if (name.Equals(word, StringComparison.OrdinalIgnoreCase)) // BETTER WAY !
                    {
                        nameCounter++;
                    }
                }
                NameCountResult nameCount = new NameCountResult(name, nameCounter);
                namesCountResultExample.Add(nameCount);
            }

            return namesCountResultExample;
        }
    }
}

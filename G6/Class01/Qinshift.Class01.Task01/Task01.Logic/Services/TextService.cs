using Task01.Logic.Models;

namespace Task01.Logic.Services
{
    public class TextService
    {
        public List<NameCountResult> CountNameAppearancesInText(string text, List<string> names)
        {
            string[] wordsInText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);



            return new List<NameCountResult>();
        }
    }
}

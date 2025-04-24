namespace Task01.Logic.Models
{
    public class NameCountResult
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public NameCountResult()
        {
            
        }

        public NameCountResult(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}

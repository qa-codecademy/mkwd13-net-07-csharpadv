namespace AbstractAndInterface.Entities
{
    public class Developer : Human
    {
        public Developer(string fullName, int age, long phoneNumber, List<string> programmingLanguages, int yearsOfExperience)
           : base(fullName, age, phoneNumber)
        {
            ProgrammingLanguages = programmingLanguages;
            YearsOfExperience = yearsOfExperience;
        }


        public List<string> ProgrammingLanguages { get; set; } = new();
        public int YearsOfExperience { get; set; }

        public void Code()
        {
            Console.WriteLine("Tak tak tak tak");
            Console.WriteLine("*Opens Stack Overflow....Copy");
            Console.WriteLine("Paste.....Tak tak tak tak");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsOfExperience} years in experience!";
        }
    }
}

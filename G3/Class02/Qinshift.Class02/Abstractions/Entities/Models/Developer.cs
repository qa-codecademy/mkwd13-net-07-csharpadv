using Abstractions.Entities.BaseEntity;
using Abstractions.Entities.Interfaces;

namespace Abstractions.Entities.Models
{
    public class Developer : Human, IDeveloper
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; } = string.Empty;
        //public string LastName { get; set; } = string.Empty;
        //public int Age { get; set; }
        //public string Phone { get; set; } = string.Empty;
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();
        public int FeaturesDeveloped { get; set; }

        public Developer(int id, string firstName, string lastName, int age, string phone, List<string> programmingLanguages, int featuresDeveloped) : base(id, firstName, lastName, age, phone)
        {
            //Id = id;
            //FirstName = firstName;
            //LastName = lastName;
            //Age = age;
            //Phone = phone;
            ProgrammingLanguages = programmingLanguages;
            FeaturesDeveloped = featuresDeveloped;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - {FeaturesDeveloped} features developed!";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak ....");
            Console.WriteLine("Opens ChatGPT ....");
            Console.WriteLine("tak tak tak tak tak....");
        }
    }
}

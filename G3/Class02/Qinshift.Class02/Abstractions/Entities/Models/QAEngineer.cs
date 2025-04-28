using Abstractions.Entities.BaseEntity;
using Abstractions.Entities.Interfaces;

namespace Abstractions.Entities.Models
{
    // We can inherit from multiple interfaces at a time
    public class QAEngineer : Human, ITester, IDeveloper
    {
        public List<string> TestingFrameworks { get; set; }

        public QAEngineer(int id, string firstName, string lastName, int age, string phone, List<string> testingFrameworks) : base(id, firstName, lastName, age, phone)
        {
            TestingFrameworks = testingFrameworks;
        }

        // "Framework 1", "Framework 2", "Framework 3" => "Framework 1, Framework 2, Framework 3"
        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - Knows testing frameworks {string.Join(", ", TestingFrameworks)}";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine("Run Unit Tests ...");
            Console.WriteLine("Run Automated Tests ...");
            Console.WriteLine($"Tests for the {feature} feature are completed!");
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak");
            Console.WriteLine("Write Automation tests ...");
            Console.WriteLine("tak tak tak");
        }
    }
}

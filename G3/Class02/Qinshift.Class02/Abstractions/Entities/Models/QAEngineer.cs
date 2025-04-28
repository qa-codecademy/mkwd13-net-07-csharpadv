using Abstractions.Entities.BaseEntity;

namespace Abstractions.Entities.Models
{
    public class QAEngineer : Human
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
    }
}

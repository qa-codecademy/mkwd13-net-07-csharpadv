using Abstractions.Entities.BaseEntity;

namespace Abstractions.Entities.Models
{
    public class Tester : Human
    {
        public int BugsFound { get; set; }

        public Tester(int id, string firstName, string lastName, int age, string phone, int bugsFound) : base(id, firstName, lastName, age, phone)
        {
            BugsFound = bugsFound;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - found {BugsFound} bugs so far!";
        }
    }
}

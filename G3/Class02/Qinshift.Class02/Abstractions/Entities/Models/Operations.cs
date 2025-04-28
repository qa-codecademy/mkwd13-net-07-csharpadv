using Abstractions.Entities.BaseEntity;
using Abstractions.Entities.Interfaces;

namespace Abstractions.Entities.Models
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; } = new List<string>();

        public Operations(int id, string firstName, string lastName, int age, string phone, List<string> projects) : base(id, firstName, lastName, age, phone)
        {
            Projects = projects;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - Currently working on {Projects.Count} projects!";
        }

        public bool CheckInfrastructure(int status)
        {
            return status < 400;
        }
    }
}

using Abstractions.Entities.BaseEntity;

namespace Abstractions.Entities.Models
{
    public class Operations : Human
    {
        public List<string> Projects { get; set; } = new List<string>();

        public Operations(int id, string firstName, string lastName, int age, string phone, List<string> projects) : base(id, firstName, lastName, age, phone)
        {
            Projects = projects;
        }
    }
}

using AdvancedLINQ.Domain.Enums;

namespace AdvancedLINQ.Domain.Models
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }

        public int Modules { get; set; }

        public int StudentsAttending { get; set; }

        public AcademyTypeEnum AcademyType { get; set; }

        public Subject() { }

        public Subject(int id, string title, int modules, int studentsAttending, AcademyTypeEnum academyType)
        {
            Id = id; 
            Title = title; 
            Modules = modules; 
            StudentsAttending = studentsAttending; 
            AcademyType = academyType;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Title} has {Modules} modules, Academy - {AcademyType.ToString()}");
        }
    }
}

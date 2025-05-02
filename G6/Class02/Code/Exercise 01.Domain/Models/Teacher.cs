using Exercise_01.Domain.Interfaces;

namespace Exercise_01.Domain.Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher(int id, string name, string username, string password, string subject)
            :base(id, name, username, password)
        {
            Subject = subject;
        }
        public override void PrintUser()
        {
            Console.WriteLine($"Teacher with id {Id} and name {Name} teaches {Subject}");
        }

        public void PrintSubject()
        {
            Console.WriteLine($"Teacher {Name} teaches {Subject}");
        }
    }
}

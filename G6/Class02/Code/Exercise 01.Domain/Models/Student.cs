using Exercise_01.Domain.Interfaces;

namespace Exercise_01.Domain.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student(int id, string name, string username, string password, List<int> grades)
            :base (id, name, username, password)
        {
            Grades = grades != null ? grades : new List<int>();
        }

        //we need an implementation here because we have an abstract method PrintUser in the User class
        public override void PrintUser()
        {
            Console.WriteLine($"Student with id {Id} name: {Name} and username {Username} has grades:");

            foreach(int grade in Grades)
            {
                Console.WriteLine($"{grade} \n");
            }
        }

        //we need to implement this method because the Student class implements the IStudent interface
        public void PrintGrades()
        {
            Console.WriteLine($"Student with username {Username} has grades:");
            foreach(int grade in Grades)
            {
                Console.WriteLine($"{grade} \n");
            }

            //there is a method Sum that we can use on collections of numbers to sum up the items
            int avgGrade = Grades.Sum() / Grades.Count();
            Console.WriteLine($"The average grade is {avgGrade}");
            
        }
    }
}

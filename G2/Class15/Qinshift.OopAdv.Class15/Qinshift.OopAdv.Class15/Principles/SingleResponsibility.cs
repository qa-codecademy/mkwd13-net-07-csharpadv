using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Qinshift.OopAdv.Class15.Principles
{
    //BAD EXAMPLE
    public class Student 
    { 
        public string Name { get; set; }
        public int Grade { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Student name: {Name}, Grade: {Grade}");
        }
        public bool IsPassing()
        {
            return Grade > 5;
        }
    }

    //GOOD EXAMPLE
    public class StundetGood
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    public class StudentInfo
    {
        public void PrintInfo(StundetGood student)
        {
            Console.WriteLine($"Student name: {student.Name}, Grade: {student.Grade}");
        }

        public bool IsPassing(StundetGood student) 
        {
            return student.Grade > 5;
        }
    }
}

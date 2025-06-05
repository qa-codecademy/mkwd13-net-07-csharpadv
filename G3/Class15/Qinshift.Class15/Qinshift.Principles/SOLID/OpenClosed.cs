namespace Qinshift.Principles.SOLID
{
    /*
       *** OPEN-CLOSED PRINCIPLE ***

           *Open* for extension 
           *Closed* for modification 

       => Business requirements change !!!
       => This means that we need to look a bit in the future when writing our code and strive to make it generic and modular

       => The software should be flexible to change
       => New features should be implemented using the new code, but not by changing existing code 
       => In practice this is not very easy to achive in many cases ===> make as less changes as possible to the existing code and make your code as flexibile as possible
    */

    #region Without OCP (BAD EXAMPLE)
    class StudentWithoutOCP
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; set; } = "Code";
        public bool HasProject { get; set; }

        public int Homeworks { get; set; }

        public bool CheckClassDay(string day)
        {
            // Code Academy
            if (Academy == "Code")
            {
                if (day == "monday" || day == "friday") return true;
            }
            if (Academy == "Design")
            {
                if (day == "tuesday" || day == "wednesday" || day == "thirsday") return true;
            }
            return false;
        }

        public void PrintStatus()
        {
            if (Academy == "Code")
            {
                if (HasProject)
                {
                    Console.WriteLine("Student has a project!");
                }
                else
                {
                    Console.WriteLine("Student is still working on project!");
                }
            }
            if (Academy == "Design")
            {
                if (Homeworks > 3)
                {
                    Console.WriteLine("Student has most of their homeworks!");
                }
                else
                {
                    Console.WriteLine("Student is still wroking on their homeworks!");
                }
            }
        }
    }

    #endregion

    #region With OCP (GOOD EXAMPLE)
    // This is the initial student added
    abstract class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AcademyType Academy { get; set; }
        public abstract bool CheckClassDay(string day);
        public abstract void PrintStatus();
    }

    enum AcademyType
    {
        None,
        Code,
        Design, // we add this when the client requests Design academy to be added
        Networks // we add this when the client requests Networks academy to be added
    }

    class CodeStudent : Student
    {
        public bool HasProject { get; set; }
        public CodeStudent()
        {
            Academy = AcademyType.Code;
        }

        public override bool CheckClassDay(string day)
        {
            if (day == "monday" || day == "friday") return true;
            return false;
        }

        public override void PrintStatus()
        {
            if (HasProject)
            {
                Console.WriteLine("Student has a project!");
            }
            else
            {
                Console.WriteLine("Student is still working on project!");
            }
        }
    }

    // We add the next student without changing the implementation that worked before ( CodeStudent )
    class DesignStudent : Student
    {
        public int Homeworks { get; set; }
        public DesignStudent()
        {
            Academy = AcademyType.Design;
        }
        public override bool CheckClassDay(string day)
        {
            if (day == "tuesday" || day == "wednesday" || day == "thirsday") return true;
            return false;
        }

        public override void PrintStatus()
        {
            if (Homeworks > 3)
            {
                Console.WriteLine("Student has most of their homeworks!");
            }
            else
            {
                Console.WriteLine("Student is still wroking on their homeworks!");
            }
        }
    }

    // We can again add new implementation without changing the previous one 
    class NetworkStudent : Student
    {
        public int Grade { get; set; }
        public NetworkStudent()
        {
            Academy = AcademyType.Networks;
        }
        public override bool CheckClassDay(string day)
        {
            if (day == "monday" || day == "saturday") return true;
            return false;
        }

        public override void PrintStatus()
        {
            if (Grade > 3)
            {
                Console.WriteLine("Student is doing well!");
            }
            else
            {
                Console.WriteLine("Student needs improvement!");
            }
        }
    }
    #endregion

}

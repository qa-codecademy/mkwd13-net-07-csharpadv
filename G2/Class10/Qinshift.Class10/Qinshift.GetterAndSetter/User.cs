namespace Qinshift.GetterAndSetter
{
    public class User
    {
        public User()
        {
            _gpa = (int)Grades.Average();
        }
        public string FullName { get; set; }

        private int _age;
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 1)
                {
                    throw new Exception("Invalid value for Age property");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public List<int> Grades { get; set; }

        private int _gpa;
        public int GPA 
        {
            get => _gpa;
            private set
            {
                value = _gpa;
            } 
        }


    }
}

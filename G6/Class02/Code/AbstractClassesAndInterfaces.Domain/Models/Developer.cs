using AbstractClassesAndInterfaces.Domain.Interfaces;

namespace AbstractClassesAndInterfaces.Domain.Models
{
    public class Developer : Person, IDeveloper
    {
        public string ProjectName { get; set; }

        public int YearsOfExperience { get; set; }

        public List<string> ProgrammingLanguages { get; set; }

        public Developer() { }  

        public Developer(string fullname, int age, string address, long phoneNumber, string projectName, int yearsOfExperience,
            List<string> programmingLanguages) //when we create a developer, this constructor is called
            :base(fullname, age, address, phoneNumber) //here the Developer constructor calls the Person (parent, base) constructor
        {
            ProjectName = projectName;
            YearsOfExperience = yearsOfExperience;
            ProgrammingLanguages = programmingLanguages == null ? new List<string>() : programmingLanguages;
        }

        //this method must be present because it is an abstract method in the parent class (Person)
        public override string GetProfessionalInfo()
        {
            return $"{FullName} works as a developer for {YearsOfExperience}. {FullName} works on {ProjectName}";
        }

        public void Code()
        {
            Console.WriteLine("Coding... \n");
            if(ProgrammingLanguages.Count > 0 )
            {
                foreach(string language in ProgrammingLanguages)
                {
                    Console.WriteLine($"Programming in {language} \n");
                }
            }
        }
    }
}

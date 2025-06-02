namespace JsonDb.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string GetInfo()
        {
           return $"{FirstName} {LastName} - {Age}";
        }
    }
}

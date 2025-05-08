namespace ExtensionMethods
{
    public class Employee
    {
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string Address {  get; set; }
        private int _salary {  get; set; }

        public int GetSalary() { return _salary; }

        public void SetSalary(int salary)
        {
            _salary = salary;
        }
    }
}

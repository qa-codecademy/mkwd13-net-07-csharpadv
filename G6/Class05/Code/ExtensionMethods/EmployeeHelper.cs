namespace ExtensionMethods
{
    public static class EmployeeHelper
    {
        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} lives on {employee.Address}");
        }

        public static void Print(this Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} lives on {employee.Address}");
        }

        public static void PrintEmployeeInfoWithAge(this Employee employee, int age)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} lives on {employee.Address} and is {age} years old");
        }
    }
}

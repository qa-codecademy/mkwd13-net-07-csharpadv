using ExtensionMethods;

Employee employee = new Employee();
employee.FirstName = "Petko";
employee.LastName = "Petkovski";
employee.Address = "Address1";
employee.SetSalary(100);

Employee employee2 = new Employee();
employee.FirstName = "Nikola";
employee.LastName = "Nikolovski";
employee.Address = "Address2";
employee.SetSalary(100);

//we need to call this method usinh the EmployeeHelper class and pass the employee as a param
EmployeeHelper.PrintEmployee(employee);

//the param in Print(this Employee employee) will be recplaced by the employee that we call the method on
//we don't need to send the employee as param
employee.Print();
employee2.Print();

//the first param in PrintEmployeeInfoWithAge(this Employee employee, int age) will be replaced by the employee on which we call the method
//we only need to send the rest of the params
employee.PrintEmployeeInfoWithAge(25);

string text = "Some text about G6 and Qinshift Academy";
string text2 = "Hello extension methods";

//StringHelper.Shorten(text, 4);
text.Shorten(4);
text2.Shorten(2);

List<Employee> list = new List<Employee>() { employee, employee2 };
List<int> ints = new List<int> { 1, 2, 3 };

string infoAboutList = list.GetInfo();
Console.WriteLine(infoAboutList);

string infoAboutInts = ints.GetInfo();
Console.WriteLine(infoAboutInts);

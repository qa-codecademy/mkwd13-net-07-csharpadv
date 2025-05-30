using AdoNet;

string connectionString = "Server=.\\SQLEXPRESS;Database=SEDC_ACADEMY_EXAMPLE;Trusted_Connection=True;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
StudentService service = new StudentService(connectionString); //create an instance of the service with the connection string

List<Student> allStudents = service.GetStudents();
Console.ReadLine();
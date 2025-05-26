using Qinshift.AdoNet.Services;

Console.WriteLine("Hello, World!");

void PrintInColor(string text, ConsoleColor color = ConsoleColor.White)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

string connectionString = "Server=.\\SQLEXPRESS;Database=SEDC_DEMO_SHARP;Trusted_Connection=True;IntegratedSecurity=True;Encrypt=False;";

StudentService studentService = new StudentService(connectionString);


string filePath = @"../../../Exercise";
string fileName = "calculations.txt";


int Calculate(int a, int b)
{
    return a + b;
}

string FormatResult(int a, int b, int result)
{
    return $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} - {a} + {b} = {result}";
}

void WriteInFile(string filePath, string fileName, string content)
{
    if (!Directory.Exists(filePath))
    {
        Directory.CreateDirectory(filePath);
    }

    using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, fileName), true))
    {
        sw.WriteLine(content);
    }
}

void ReadFromFile(string filePath, string fileName)
{
    using (StreamReader sr = new StreamReader(Path.Combine(filePath, fileName)))
    {
        string content = sr.ReadToEnd();
        Console.WriteLine(content);
    }
}

int ConvertToInt(string input)
{
    if(!int.TryParse(input, out int number))
    {
        throw new Exception("Wrong input");
    }
    return number;
}



for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Please enter first number:");
    string userInput1 = Console.ReadLine();

    Console.WriteLine("Please enter second number:");
    string userInput2 = Console.ReadLine();

    int a = ConvertToInt(userInput1);
    int b = ConvertToInt(userInput2);

    WriteInFile(filePath, fileName, FormatResult(a, b, Calculate(a, b)));
}

ReadFromFile(filePath, fileName);
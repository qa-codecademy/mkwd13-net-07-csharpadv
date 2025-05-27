string folderPath = @"..\..\..\Exercise";
string filePath = folderPath + @"\calculations.txt";

string Calculate(int num1, int num2)
{
    return $"{num1} + {num2} = {num1 + num2}";
}

Console.WriteLine("Enter first number");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter second number");
string secondInput = Console.ReadLine();

bool firstSuccess = int.TryParse(firstInput, out int firstNumber);
bool secondSuccess = int.TryParse(secondInput, out int secondNumber);

if(firstSuccess && secondSuccess)
{
    string result = Calculate(firstNumber, secondNumber);

    //create a folder called Exercise
    if (!Directory.Exists(folderPath))
    {
        Directory.CreateDirectory(folderPath);
    }

    //StreamWriter will create the file if it does not already exist
    using (StreamWriter sw = new StreamWriter(filePath, true)) //we want to append the text in the file
    {
        sw.WriteLine($"{DateTime.Now: dd.MM.yyyy HH.mm.ss} : {result}");
        sw.WriteLine("================================================");
    }

}


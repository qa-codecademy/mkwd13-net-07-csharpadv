
// Create Calculator console app, that for entered 2 numbers
// and operation from the user will calculate the appropriate result

int Sum(int a, int b)
{
    return a + b;
}

int Difference(int a, int b)
{
    return a - b;
}

int Multiply(int a, int b)
{
    return a * b;
}

double Division(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Cannot divide by zero!");
        return 0;
    }
    return Math.Round(a / b, 2);
}


while (true)
{
    Console.Clear();
    Console.WriteLine("Enter first number:");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter second number:");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter operation:");
    string operation = Console.ReadLine();

    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
    {
        switch (operation)
        {
            case "+":
                Console.WriteLine(Sum(num1, num2));
                break;
            case "-":
                Console.WriteLine(Difference(num1, num2));
                break;
            case "*":
                Console.WriteLine(Multiply(num1, num2));
                break;
            case "/":
                Console.WriteLine(Division(num1, num2));
                break;
            default:
                break;
        }
        Console.WriteLine("Do you want to calculate again? Y/N");
        string userChoice = Console.ReadLine();
        if (userChoice.ToLower() == "n")
            break;
    }
    else
    {
        Console.WriteLine("Invalid operation entered! Try again!");
    }

}




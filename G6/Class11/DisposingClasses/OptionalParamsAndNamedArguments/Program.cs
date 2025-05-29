void CalculationWithNoOptionalParams(int num1, int num2, string operation)
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        default: Console.WriteLine("Invalid operator"); break;
    }
}


CalculationWithNoOptionalParams(3, 4, "-"); //we must provide values for all params
//CalculationWithNoOptionalPatams(3, 4); //ERROR

//Always put the required params first, then the optional params
//we must provide values for num1 and num2, but we don't have to provide a value for operation
void CalculationWithOneOptionalParams(int num1, int num2, string operation="+")
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        default: Console.WriteLine("Invalid operator"); break;
    }
}

CalculationWithOneOptionalParams(3, 4, "-"); //operation will get the value "-"
CalculationWithOneOptionalParams(4, 5); //operation will get the default value "+"

void CalculationWithAllOptionalParams(int num1 = 0, int num2 = 0, string operation = "+")
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        default: Console.WriteLine("Invalid operator"); break;
    }
}

CalculationWithAllOptionalParams(); //0,0,+
CalculationWithAllOptionalParams(10); //10, 0, +
CalculationWithAllOptionalParams(10, 12); //10, 12, +
CalculationWithAllOptionalParams(10, 12, "-"); //10,12, -

//when using named arguments we can change the order of passing the values
CalculationWithAllOptionalParams(num1: 5, num2: 6, operation: "-");
CalculationWithAllOptionalParams(num2: 5); //num1=0, num2=5, operation = +
CalculationWithAllOptionalParams(num2: 7, num1: 8, operation: "+");
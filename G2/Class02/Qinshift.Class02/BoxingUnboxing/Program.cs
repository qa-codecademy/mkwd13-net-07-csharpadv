

// Boxing - the process of converting a value
// type (such as int) to a reference type (such as object)
int number = 90;
object obj = number;
Console.WriteLine(obj);

void PrintObj(object obj)
{
    Console.WriteLine(obj);
}

PrintObj(number);
PrintObj(true);
PrintObj(2.4);



object name = "Martin";
int number2 = (int)name;
PrintObj(number2);
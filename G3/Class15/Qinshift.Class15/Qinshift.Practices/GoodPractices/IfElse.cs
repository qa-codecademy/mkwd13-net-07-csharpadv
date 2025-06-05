namespace Qinshift.Practices.GoodPractices
{
    /*
        NOTE:
        1. In most of the cases it's better to handle the negative scenarios first
        2. Keep your code as further to the left as possible
        3. For multiple condition statements try using switch instead
     */

    internal class IfElse
    {
        // REQUIREMENT: Check if two numbers are the same but only from 2 to 100 even numbers
        public void CheckTwoNumbers(int num1, int num2)
        {
            // Bad example
            if (num1 <= 100 && num2 <= 100)
            {
                if (num1 % 2 == 0 && num2 % 2 == 0)
                {
                    if (num1 == num2)
                    {
                        Console.WriteLine("They are the same");
                    }
                }
            }

            // Good Example
            if (num1 > 100 || num2 > 100) return;
            if (num1 % 2 != 0 || num2 % 2 != 0) return;
            if (num1 != num2) return;
            Console.WriteLine("They are the same");
        }
    }
}

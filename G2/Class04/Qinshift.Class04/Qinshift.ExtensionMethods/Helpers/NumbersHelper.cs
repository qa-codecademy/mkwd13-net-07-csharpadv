namespace Qinshift.ExtensionMethods.Helpers
{
    public static class NumbersHelper
    {

        public static bool IsEven(this int value)
        {
            if(value == 0) 
                throw new ArgumentException("The number is 0");
            return value % 2 == 0;
        }
    }
}

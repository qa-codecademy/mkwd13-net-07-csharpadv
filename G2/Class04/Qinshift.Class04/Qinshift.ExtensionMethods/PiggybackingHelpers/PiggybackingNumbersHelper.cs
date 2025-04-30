namespace Qinshift.ExtensionMethods.PiggybackingHelpers
{
    public static class PiggybackingNumbersHelper
    {

        public static bool PiggybackingIsEven(this int value)
        {
            if(value == 0) 
                throw new ArgumentException("The number is 0");
            return value % 2 == 0;
        }
    }
}

namespace StaticClasses.Entities.Helpers
{
    public static class ValidationHelper
    {
        public static int ValidateNumberInput(string input)
        {
            bool isValidInput = int.TryParse(input, out int parsedInput);
            if (!isValidInput)
            {
                return -1;
            }
            return parsedInput;
        }
    }
}

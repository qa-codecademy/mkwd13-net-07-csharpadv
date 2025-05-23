namespace TaxiManager9000.Helpers
{
    public static class ValidationHelper
    {
        public static int ValidateNumberInput(string number, int range)
        {
            bool isNumber = int.TryParse(number, out int num);
            if (!isNumber || num <= 0 || num > range)
            {
                return -1;
            }
            return num;
        }

        public static bool ValidateStringInput(string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        public static bool ValidateUsername(string username)
        {
            return username.Length >= 5;
        }

        public static bool ValidatePassword(string password)
        {
            return password.Length >= 5 && password.Any(c => char.IsNumber(c));
        }
    }
}

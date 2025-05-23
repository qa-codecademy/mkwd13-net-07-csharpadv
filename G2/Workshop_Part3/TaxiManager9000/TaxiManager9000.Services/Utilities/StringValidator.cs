namespace TaxiManager9000.Services.Utilities
{
    public static class StringValidator
    {
        public static int ValidateNumber(string number, int maxValue)
        {
            bool isNumber = int.TryParse(number, out int num);
            if (!isNumber || num <= 0 || num > maxValue) return -1;
            return num;
        }

        public static bool ValidateUsername(string username)
        {
            if (username.Length < 6) return false;
            return true;
        }


        public static bool ValidatePassword(string password)
        {
            if(password.Length < 6) return false;

            bool isNum = false;
            foreach (char item in password) 
            {
                isNum = int.TryParse(item.ToString(), out int num);
                if (isNum)
                    break;
            }
            return isNum;
        }
    }
}

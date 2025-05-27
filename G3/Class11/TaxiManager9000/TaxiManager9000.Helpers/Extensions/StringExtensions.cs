namespace TaxiManager9000.Helpers.Extensions
{
    public static class StringExtensions
    {
        public static string ToSeparateString(this string value)
        {
            string result = value[0].ToString();
            for (int i = 1; i < value.Length; i++)
            {
                if (char.IsUpper(value[i]))
                {
                    result += $" {value[i]}";
                }
                else
                {
                    result += value[i];
                }
            }
            return result;
        }
    }
}

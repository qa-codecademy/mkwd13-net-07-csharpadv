using System.Xml.Linq;

namespace TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        //There should be a validation on first name and lastname to not be shorter than 2 characters
        public static bool ValidateName(string name)
        {
            if(string.IsNullOrEmpty(name) || name.Length < 2)
            {
                return false; //the name is not valid
            }

            return true; //the name is valid
        }

        //Username should not be shorter than 6 characters
        public static bool ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 6)
            {
                return false; //the username is not valid
            }

            return true; //the username is valid
        }

        //Password should not be shorter than 6 characters and should contain at least 1 number
        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                return false; //the password is not valid
            }

            //  if(password.Contains("0") || password.Contains("1") || password.Contains("2") || password.Contains("3"))

            //var passwordArray = password.ToCharArray();
            foreach (char c in password) {

                bool isParsed = int.TryParse(c.ToString(), out int value); //the first param of TryParse must always be string
                if(isParsed)
                {
                    return true; //return true only if the character was parsed (do not return false if the parse was unsuccessfull, that way only the first character would be tested for parsing)
                }

                //bool isDigit = Char.IsDigit(c);
                //if(isDigit)
                //{
                //    return true; //return true only if the char is digit (don't return false if the char is not digit, that way only the first char will be tested if it is digit)
                //}
            }

            return false; //return false after you iterated each char in the string and none of them was successfully parsed
        }
    }
}

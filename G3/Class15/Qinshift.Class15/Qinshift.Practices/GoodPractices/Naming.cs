namespace Qinshift.Practices.GoodPractices
{
    /*
        *** NAMING GOOD PRACTICES ***

        0. Don't use space when naming solutions, projects, folders....anything. 

        1. Classes, Methods, Properties, Interfaces, public fields are written in PascalCase
        2. Variables and Parameters are always written in camelCase
        3. Private fields are always written with underscore camelCase ( ex: _privateField )

        4. Write Descriptive names !!!
    */

    #region CLASSES, PROPERTIES, FIELDS, METHODS

    // Bad Example
    internal class user
    {
        private readonly string usersFolder = @"C:\users";
        public int id;
        public string username;
        public string Password;



        public int age;
        public bool Logged { get; set; } = false;
        public List<string> HobbyList { get; set; }

        public void Username(string Username)
        {
            this.username = Username;
        }
        public void changePwd(string pwd)
        {
            Password = pwd;
        }
        public async void PrintUserInfo()
        {
            // code
        }
    }

    // Good Example
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public bool IsLoggedIn { get; set; }
        public List<string> Hobbies { get; set; } = new List<string>();

        private readonly string _usersFolder = @"C:\users";
        //public string FilePath = string.Empty;  => if it's public the field is named using PascalCase

        public User()
        {

        }

        public void ChangeUsername(string username)
        {
            Username = username;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public async Task PrintUserInfoAsync()
        {
            // code
        }
    }

    // TIPS : 
    // 1. Write boolean names so that they can be answered with YES or NO (IsDeleted, IsAdmin, HasCheckedIn) => usually starts with "Is","Can" or "Has"
    // 2. Boolean is false by default, there is no need to set it to false initially
    // 3. Avoid using fields unless they are private
    // 4. Avoid using 'this' keyword when addresing a property
    // 5. Add the suffix "Async" to the name of an asynchronious method 
    // 6. Avoid using Abbreviations (pwd, usn => password, username)
    // 7. Methods names should be verbs / verb phrases
    // 8. Avoid unnecessary empty lines in the code
    // 9. Prefer using plural phrase for collection properties instead of adding the suffix words "List" or "Collection"

    #endregion


    #region ENUMS
    // Bad Example
    public enum RoleEnum
    {
        Admin,
        User
    }

    // Good Example
    public enum Role
    {
        Admin = 1,
        User = 2
    }

    // NOTE : 
    // 1. Don't use the word 'Enum' when naming enums
    // 2. Numbering the enums makes them more readable (optional)
    #endregion


    #region INTERFACES
    // Bad Example
    public interface UserService
    {
        public void PrintUser(string username)
        {
            // code ...
        }
    }

    // Good Example
    public interface IUserService
    {
        void PrintUsers();
    }
    #endregion

}

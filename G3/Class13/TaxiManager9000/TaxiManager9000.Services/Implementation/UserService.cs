using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Helpers;
using TaxiManager9000.Services.Abstraction;
using TaxiManager9000.Services.Abstraction.Interfaces;

namespace TaxiManager9000.Services.Implementation
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public User CurrentUser { get; set; }

        public void LogIn(string username, string password)
        {
            var allUsers = GetAll();
            User userDb = allUsers.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (userDb is null)
            {
                throw new Exception("Login failed! Invalid credentials entered! Try again...");
            }
            CurrentUser = userDb;
        }

        public void CreateNewUser(string username, string password, Role role)
        {
            List<User> usersDb = GetFiltered(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            bool userExists = usersDb.Any();
            if (userExists)
            {
                throw new Exception("User already exists!");
            }

            User newUser = new User(username, password, role);
            Insert(newUser);
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (CurrentUser.Password != oldPassword || !ValidationHelper.ValidatePassword(newPassword) || oldPassword == newPassword)
            {
                return false;
            }
            CurrentUser.Password = newPassword;
            bool isUpdated = Update(CurrentUser);
            return isUpdated;
        }

    }
}

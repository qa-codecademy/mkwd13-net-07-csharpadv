using TaxiManager9000.Domain.Models;
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
    }
}

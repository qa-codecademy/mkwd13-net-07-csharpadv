using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public User CurrentUser { get; set; }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            User user = _dbInstance.GetById(CurrentUser.Id);
            if (user.Password != oldPassword)
                return false;
            user.Password = newPassword;
            _dbInstance.Update(user);
            return true;
        }

        public void LogIn(string username, string password)
        {
            CurrentUser = _dbInstance
                .GetAll()
                .SingleOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == password);

            if (CurrentUser is null)
                throw new Exception("Login Failed! Please try again");
        }
    }
}

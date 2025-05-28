using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Abstraction.Interfaces
{
    public interface IUserService : IServiceBase<User>
    {
        User CurrentUser { get; set; }
        void LogIn(string username, string password);
        void CreateNewUser(string username, string password, Role role);
        bool ChangePassword(string oldPassword, string newPassword);

    }
}

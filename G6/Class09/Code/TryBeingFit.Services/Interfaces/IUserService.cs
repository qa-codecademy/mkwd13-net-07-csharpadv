using TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        T RegisterUser(T newUser);
        T Login(string username, string password);
        List<T> GetAllUsers();
    }
}

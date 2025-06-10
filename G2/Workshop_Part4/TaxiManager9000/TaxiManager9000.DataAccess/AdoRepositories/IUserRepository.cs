
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess.AdoRepositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task Insert(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}

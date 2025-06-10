using TaxiManager9000.DataAccess.AdoRepositories;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services
{
    public class UserAdoService
    {
        private const string connString = "Server=.;Database=TaxiManager;Trusted_Connection=True;TrustServerCertificate=True;";
        private readonly IUserRepository _userRepository;

        public UserAdoService()
        {
            _userRepository = new AdoUserRepository(connString);
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _userRepository.GetAllAsync();
            return users.ToList();
        }
    }
}

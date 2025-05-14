using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Role Role { get; set; }

        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public User()
        {

        }

        public override string GetInfo()
        {
            return $"User with username: [{Username}] and role: [{Role}]";
        }
    }
}

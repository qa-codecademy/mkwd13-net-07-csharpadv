using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class User : BaseEntity
    {
        public User()
        {
            
        }

        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public override string Print()
        {
            return $"{Username} with the role of {Role}";
        }
    }
}

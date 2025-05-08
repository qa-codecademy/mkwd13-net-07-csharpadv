using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
}

using TryBeingFit.Domain.Enums;

namespace TryBeingFit.Domain.Models
{
    //we don't want to be able to creater an user that is just a user, so we make this class abstract
    public abstract class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public UserRoleEnum Role { get; set; }
    }
}

using Exercise_01.Domain.Interfaces;

namespace Exercise_01.Domain.Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        //we will implement the method in each of the derived classes
        public abstract void PrintUser();
    }
}


using TryBeingFit.Domain.Database;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.Implementation
{
    public class UserService<T> : IUserService<T> where T : User
    {
        //always make the classes dependent on interface (depend only on the signature)
        //this way we sill be able to provide different impl that impl the same methods
        private IDatabase<T> _database;

        public UserService()
        {
            //we can always assign an object from a class that implements the interface to a variable
            //with type interface(new Database -> IDataase)
            _database = new Database<T>();

            //if eventually we want to change the impl and use an impl of another class
            //the only place that we need to change is here
            //we are sure that this FileDatabase has all the methods that were user by Database.cs because
            //all the methods are from the IDatabase interface which is implemented by both Database and FileDatabase
            //_database = new FileDatabase<T>();
        }

        public T ChangeInfo(int userId, string firstName, string lastName)
        {
            //find the user
            T user = _database.GetById(userId);
            if(user == null)
            {
                throw new Exception("User does not exist");
            }
            if (!ValidationHelper.ValidateName(firstName))
            {
                throw new Exception("Invalid first name");
            }

            if (!ValidationHelper.ValidateName(lastName))
            {
                throw new Exception("Invalid last name");
            }

            user.FirstName = firstName;
            user.LastName = lastName;
            _database.Update(user);
            return user;
        }

        public T ChangePassword(int userId, string oldPassword, string newPassword)
        {
            //find the user
            T user = _database.GetById(userId);
            if (user == null)
            {
                throw new Exception("User does not exist");
            }

            //validation of old password
            if(user.Password != oldPassword)
            {
                throw new Exception("Old passwords do not match");
            }

            //validation of the new password
            if (!ValidationHelper.ValidatePassword(newPassword))
            {
                throw new Exception("Invalid password");
            }
            user.Password = newPassword;
            _database.Update(user);
            return user;
        }

        public List<T> GetAllUsers()
        {
           List<T> allItems = _database.GetAll();
            return allItems;
        }

        public T Login(string username, string password)
        {
            //1. search through all users for a user with the given username and pass
            //1.1 get all users
            List<T>  allUsers= _database.GetAll();
            //1.2 search
            T user = allUsers.FirstOrDefault(x => x.Username == username && x.Password == password);
            if(user == null)
            {
                throw new Exception("Wrong username or password");
            }

            //2.return the user
            return user;
        }

        public T RegisterUser(T newUser)
        {
            //1. validation 
            if(newUser == null)
            {
                throw new Exception("User cannot be null");
            }

            List<T> allUsers = GetAllUsers();
            bool alreadyExists = allUsers.Any(x => x.Username == newUser.Username && x.Password == newUser.Password);
            if(alreadyExists)
            {
                throw new Exception("User already exists");
            }

            //T userInDb = allUsers.FirstOrDefault(x => x.Username == newUser.Username && x.Password == newUser.Password);
            //if (userInDb != null)
            //{
            //    throw new Exception("User already exists");
            //}

            if (!ValidationHelper.ValidateName(newUser.FirstName)){
                throw new Exception("Invalid first name");
            }

            if (!ValidationHelper.ValidateName(newUser.LastName))
            {
                throw new Exception("Invalid last name");
            }

            if (!ValidationHelper.ValidateUsername(newUser.Username))
            {
                throw new Exception("Invalid username");
            }

            if (!ValidationHelper.ValidatePassword(newUser.Password))
            {
                throw new Exception("Invalid password");
            }

            //2. insert into the db (into our list of items)
            int id = _database.Insert(newUser);

            //3. find and return the new user object
            //newUser.Id = id;
            //return newUser;

            T user = _database.GetById(id); //the safest way to return all the data about the new user
            return user;
        }

        public void RemoveById(int userId)
        {
            //validation 
            T user = _database.GetById(userId);
            if(user == null)
            {
                throw new Exception("User does not exist");
            }
            _database.RemoveById(userId);
        }
    }
}

namespace Qinshift.Principles.SOLID
{
    /*
        *S*ingle Responsibility Principle (SRP)
        *O*pen-Closed Principle (OCP)
        *L*iskov Substitution Principle (LSP)
        *I*nterface Segregation Principle (ISP)
        *D*ependency Inversion Principle (DIP)
    

        *** Single Responsibility Principle (SRP) ***
       
        => Class or module should have a very small piece of responsibility in the entire application.
        => Break the code into smaller logical pieces !!!
        => This helps us to easily navigate through our application code and add new features easily. 
        => With this principle used, we can make our application more flexible and scalable.
     */

    class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    class Driver
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? LicensePlate { get; set; }
    }


    #region Services Example
    // Without SRP (BAD EXAMPLE)
    class TaxiServiceWithoutSRP
    {
        public bool Login(string username, string password)
        {
            // code...
            return false;
        }

        public int Register(User user)
        {
            // code...
            return user.Id;
        }

        public List<User> GetAllUsers()
        {
            // code...
            return new List<User>();
        }

        public List<Driver> GetAllDrivers()
        {
            // code...
            return new List<Driver>();
        }

        public List<Car> GetAllCars()
        {
            // code...
            return new List<Car>();
        }

        public List<string> GetAllLicensePlates()
        {
            // code...
            return new List<string>();
        }
    }

    // With SRP (GOOD EXAMPLE)
    class UserService
    {
        public bool Login(string username, string password)
        {
            // code...
            return false;
        }

        public int Register(User user)
        {
            // code...
            return user.Id;
        }

        public List<User> GetAllUsers()
        {
            // code...
            return new List<User>();
        }
    }

    class DriverService
    {
        public List<Driver> GetAllDrivers()
        {
            // code...
            return new List<Driver>();
        }
    }

    class CarService
    {
        public List<Car> GetAllCars()
        {
            // code...
            return new List<Car>();
        }

        public List<string> GetAllLicensePlates()
        {
            // code...
            return new List<string>();
        }
    }
    #endregion


    #region Models Example
    class PersonWithoutSRP
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Street { get; set; }
        public string? StreetNumber { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }

    // With SRP (GOOD EXAMPLE)
    class PersonWithSRP
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Address? Address { get; set; }
    }

    class Address
    {
        public string? Street { get; set; }
        public string? StreetNumber { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }
    #endregion

}

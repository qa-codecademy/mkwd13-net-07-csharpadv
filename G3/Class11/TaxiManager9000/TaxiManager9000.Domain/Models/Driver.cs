using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public Shift Shift { get; set; }
        public Car Car { get; set; }
        public string License { get; set; } 
        public DateTime LicenseExpieryDate { get; set; }

        public Driver(string firstName, string lastName, Shift shift, Car car, string license, DateTime licenseExpieryDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            Car = car;
            License = license;
            LicenseExpieryDate = licenseExpieryDate;
        }

        public override string GetInfo()
        {
            return $"Driver {FirstName} {LastName} with license {License} that expires on {LicenseExpieryDate} drives the car {Car.Model} model.";
        }
    }
}

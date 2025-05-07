using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public Shift Shift { get; set; }

        public Car? Car { get; set; }

        public string License { get; set; } 
        public DateTime LicenseExpieryDate { get; set; }
    }
}

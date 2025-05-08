namespace TaxiManager9000.Domain.Models
{
    public class Car : BaseEntity
    {
        public string Model { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public DateTime LicensePlateExpieryDate { get; set; }

        public List<Driver> AsignedDrivers { get; set; } = new();
    }
}

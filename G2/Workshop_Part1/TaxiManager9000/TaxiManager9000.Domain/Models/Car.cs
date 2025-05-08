namespace TaxiManager9000.Domain.Models
{
    public class Car : BaseEntity
    {
        public Car()
        {
            
        }
        public Car(string model, string licensePlate, DateTime expiryDate)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpiryDate = expiryDate;
            DriversAssigned = new List<Driver>();
        }

        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime LicensePlateExpiryDate { get; set; }
        public List<Driver> DriversAssigned { get; set; }


        public override string Print()
        {
            int assignedPercent = DriversAssigned.Count == 0 ? 0 : 100 / 3 * DriversAssigned.Count + 1;
            return $"{Id}) {Model} with license plate {LicensePlate} and utilized {assignedPercent}%";
        }
    }
}

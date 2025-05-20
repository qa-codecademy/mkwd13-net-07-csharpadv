using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services
{
    public class DriverService : ServiceBase<Driver>, IDriverService
    {
        public void AssignDriver(Driver driver, Car car)
        {
            driver.Car = car;
            _dbInstance.Update(driver);
        }

        public void UnassignDriver(Driver driver)
        {
            driver.Car = null;
            _dbInstance.Update(driver);
        }

        public bool IsAvailableDriver(Driver driver)
        {
            return driver.IsLicenseExpired() == ExpiryStatus.Expired || 
                driver.Car != null ? false : true;
        }
    }
}

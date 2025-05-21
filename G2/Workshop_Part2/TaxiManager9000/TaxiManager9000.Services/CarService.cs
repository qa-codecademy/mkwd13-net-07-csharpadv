using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        #region OldWay
        //public bool IsAvailableCar(Car car)
        //{
        //    if (car.IsLicensePlateExpired() == ExpiryStatus.Expired ||
        //        car.DriversAssigned.Count == 3)
        //        return false;
        //    return true;
        //}
        #endregion

        public bool IsAvailableCar(Car car) => 
            car.IsLicensePlateExpired() == ExpiryStatus.Expired || 
             car.DriversAssigned?.Count == 3 ? false : true;
    }
}

using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Interfaces
{
    public interface ICarService : IServiceBase<Car>
    {
        bool IsAvailableCar(Car car);
    }
}

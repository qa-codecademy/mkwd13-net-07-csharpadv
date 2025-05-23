using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Utilities
{
    public static class ListExtensions
    {
        private static readonly Dictionary<ExpiryStatus, ConsoleColor> StatusColorMapper = new()
        {
            {ExpiryStatus.Valid, ConsoleColor.Green },
            {ExpiryStatus.Warning, ConsoleColor.Yellow },
            {ExpiryStatus.Expired, ConsoleColor.Red }
        };

        public static void Print<T>(this List<T> list) where T : BaseEntity
        {
            if (list.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<T>();
            }
            else
            {
                foreach (T item in list)
                {
                    Console.WriteLine(item.Print());
                }
            }

        }

        public static void PrintStatus(this List<Car> list)
        {
            if(list.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<Car>();
            }
            else 
            {
                foreach (var car in list)
                {
                    ExpiryStatus status = car.IsLicensePlateExpired();
                    ExtendedConsole.Write($"[{status}]) ", StatusColorMapper[status]);
                    Console.WriteLine($"Car Id: {car.Id} - Plate: {car.LicensePlate} with expiry date: {car.LicensePlateExpiryDate}");
                }
            }
            Console.ReadLine();
        }

        public static void PrintStatus(this List<Driver> list)
        {
            if(list.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<Driver>();
            }
            else
            {
                foreach(var driver in list)
                {
                    ExpiryStatus status = driver.IsLicenseExpired();
                    ExtendedConsole.Write($"[{status}]) ", StatusColorMapper[status]);
                    Console.WriteLine($"Driver: {driver.FullName} with license {driver.License} with expiry date: {driver.LicenseExpiryDate}");
                }
            }
            Console.ReadLine();
        }
    }
}

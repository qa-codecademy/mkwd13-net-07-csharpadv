using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Abstraction.Interfaces
{
    public interface IUIService
    {
        int ChooseMenu<T>(List<T> menus);
        User LoginMenu();
    }
}

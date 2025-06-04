using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Enums;

namespace TaxiManager9000.Services.Interfaces
{
    public interface IUIService
    {
        List<MenuChoice> MenuItems { get; set; }
        User LogInMenu();
        void Welcome(User user);
        int MainMenu(Role role);
        int ChooseMenu<T>(List<T> items);
        int ChooseEntitiesMenu<T>(List<T> entities) where T : BaseEntity;
    }
}

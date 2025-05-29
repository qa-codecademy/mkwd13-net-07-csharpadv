﻿using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Enums;

namespace TaxiManager9000.Services.Abstraction.Interfaces
{
    public interface IUIService
    {
        List<MenuChoice> MenuItems { get; set; }
        int ChooseMenu<T>(List<T> menus);
        int ChooseEntitiesMenu<T>(List<T> entities) where T : BaseEntity;
        User LoginMenu();
        int MainMenu(Role role);
        void EndMenu();
    }
}

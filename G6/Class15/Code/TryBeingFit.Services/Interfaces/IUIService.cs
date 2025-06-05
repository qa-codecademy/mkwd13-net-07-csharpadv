using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface IUIService
    {
        StandardUser FillRegisterData();

        string MainMenu(UserRoleEnum? userRole);
    }
}

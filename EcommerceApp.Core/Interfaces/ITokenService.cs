using EcommerceApp.Core.Entities.Identity;

namespace EcommerceApp.Core.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}

using Microsoft.AspNetCore.Identity;

namespace NZ_Walks.api.IRepositories
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}

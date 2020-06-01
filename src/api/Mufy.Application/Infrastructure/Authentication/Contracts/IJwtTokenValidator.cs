using System.Security.Claims;

namespace Mufy.Application.Infrastructure.Authentication.Contracts
{
    public interface IJwtTokenValidator
    {
        ClaimsPrincipal GetPrincipalFromToken(string token, string signingKey);
    }
}

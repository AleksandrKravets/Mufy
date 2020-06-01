using Mufy.Application.Contracts.Repositories;

namespace Mufy.DAL.Repositories
{
    public class TokensRepository : ITokensRepository
    {
        public bool HasUserValidRefreshToken(long userId, string token)
        {
            // return _refreshTokens.Any(rt => rt.Token == refreshToken && rt.Active);
            throw new System.NotImplementedException();
        }
    }
}

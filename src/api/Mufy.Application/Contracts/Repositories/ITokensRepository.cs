using System;
using System.Threading.Tasks;

namespace Mufy.Application.Contracts.Repositories
{
    public interface ITokensRepository
    {
        Task<bool> HasUserValidRefreshTokenAsync(long userId, string token);
        Task CreateAsync(string token, string jwtId, DateTime creationDate, DateTime expiryDate, long userId);
    }
}

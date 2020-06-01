using Mufy.Application.DataTransferObjects.Users;
using System.Threading.Tasks;

namespace Mufy.Application.Contracts.Repositories
{
    public interface IUsersRepository
    {
        Task<UserDto> GetByEmailAsync(string email);
    }
}

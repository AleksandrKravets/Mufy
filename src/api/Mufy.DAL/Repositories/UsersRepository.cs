using Mufy.Application.Contracts.Repositories;
using Mufy.Application.DataTransferObjects.Users;
using System.Threading.Tasks;

namespace Mufy.DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public Task<UserDto> GetByEmailAsync(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}

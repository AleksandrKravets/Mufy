using System.Data.Common;
using System.Threading.Tasks;

namespace Mufy.DAL.Infrastructure.Commands
{
    internal class ExecuteWithoutResponseCommand : CommandBase<int>
    {
        public ExecuteWithoutResponseCommand(string connectionString) : base(connectionString) { }

        protected override async Task<int> ExecuteAsync(DbCommand command)
        {
            var rowsAffected = await command.ExecuteNonQueryAsync();
            return rowsAffected;
        }
    }
}

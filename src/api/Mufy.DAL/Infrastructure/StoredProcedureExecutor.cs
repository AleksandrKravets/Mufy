using Microsoft.Extensions.Options;
using Mufy.DAL.Infrastructure.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mufy.DAL.Infrastructure
{
    internal class StoredProcedureExecutor
    {
        private readonly string _connectionString;

        public StoredProcedureExecutor(IOptions<DatabaseSettings> settings)
        {
            _connectionString = settings.Value.ConnectionString;
        }

        public Task<ICollection<TResult>> ExecuteWithListResponseAsync<TResult>(StoredProcedure storedProcedure) where TResult : class
        {
            var command = new ExecuteWithListResponseCommand<TResult>(_connectionString);
            return command.ExecuteAsync(storedProcedure);
        }

        public Task<TResult> ExecuteWithObjectResponseAsync<TResult>(StoredProcedure storedProcedure) where TResult : class
        {
            var command = new ExecuteWithObjectResponseCommand<TResult>(_connectionString);
            return command.ExecuteAsync(storedProcedure);
        }

        public Task<int> ExecuteAsync(StoredProcedure storedProcedure)
        {
            var command = new ExecuteWithoutResponseCommand(_connectionString);
            return command.ExecuteAsync(storedProcedure);
        }
    }
}

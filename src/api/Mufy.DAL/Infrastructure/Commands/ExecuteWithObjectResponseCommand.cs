using System.Data.Common;

namespace Mufy.DAL.Infrastructure.Commands
{
    internal class ExecuteWithObjectResponseCommand<TResult> : ExecuteWithResponseCommand<TResult> where TResult : class
    {
        public ExecuteWithObjectResponseCommand(string connectionString) : base(connectionString) { }

        protected override TResult Execute(DbDataReader reader)
        {
            var result = reader.ReadObject<TResult>();
            return result;
        }
    }
}

using System.Collections.Generic;
using System.Data.Common;

namespace Mufy.DAL.Infrastructure.Commands
{
    internal class ExecuteWithListResponseCommand<TResult> : ExecuteWithResponseCommand<ICollection<TResult>> where TResult : class
    {
        public ExecuteWithListResponseCommand(string connectionString) : base(connectionString) { }

        protected override ICollection<TResult> Execute(DbDataReader reader)
        {
            var result = reader.ReadList<TResult>();
            return result;
        }
    }
}

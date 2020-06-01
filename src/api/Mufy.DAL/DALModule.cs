using Microsoft.Extensions.DependencyInjection;
using Mufy.DAL.Infrastructure;

namespace Mufy.DAL
{
    public static class DALModule
    {
        public static void AddDALModule(this IServiceCollection services)
        {
            services.AddTransient<StoredProcedureExecutor>();
        }
    }
}

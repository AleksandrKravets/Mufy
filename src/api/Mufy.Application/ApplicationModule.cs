using Microsoft.Extensions.DependencyInjection;
using Mufy.Application.Commands.Authentication;
using Mufy.Application.Infrastructure;

namespace Mufy.Application
{
    public static class ApplicationModule
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.RegisterModule<AuthModule>();
        }
    }
}

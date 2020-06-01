using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Mufy.Application.Infrastructure
{
    public static class ModuleRecorder
    {
        public static void RegisterModule<T>(this IServiceCollection services)
        {
            var moduleType = typeof(T);

            var properties = moduleType.GetProperties(
                BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.GetProperty);

            Array.ForEach(properties, x => services.AddTransient(x.GetType()));
        }
    }
}

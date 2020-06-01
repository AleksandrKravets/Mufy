using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Mufy.API.Extensions;
using Mufy.API.Infrastructure.Authentication;
using Mufy.Common.Settings;
using System.Threading.Tasks;

namespace Mufy.API
{
    public static class ApiModule
    {
        public static void AddApiModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().AddNewtonsoftJson();
            services.AddCustomAuthorization();
            services.AddCustomAuthentication(configuration);
            services.ConfigureSetting<JwtSettings>(configuration);

            //services.AddCors(options => options.AddPolicy("AllowAllOrigin",
            //                                     builder => builder.AllowAnyHeader()
            //                                                       .AllowAnyMethod()
            //                                                       .SetIsOriginAllowed((host) => true)
            //                                                       .WithOrigins("http://localhost:4200")
            //                                                       .AllowCredentials()));
        }

        public static void AddCustomAuthorization(this IServiceCollection services)
        {
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("Policy Name", policy => policy.RequireClaim("Claim", "AllowedValue1", "AllowedValue2"));
            //});
        }

        public static void AddCustomAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            //var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            //services.Configure<JwtIssuerOptions>(options =>
            //{
            //    options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
            //    options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
            //    options.SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            //});

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(configureOptions =>
            {
                configureOptions.RequireHttpsMetadata = false; // SSL не используется
                configureOptions.SaveToken = true;
                configureOptions.TokenValidationParameters = new JwtAuthParameters(configuration);
                configureOptions.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
                    }
                };
            });
        }
    }
}

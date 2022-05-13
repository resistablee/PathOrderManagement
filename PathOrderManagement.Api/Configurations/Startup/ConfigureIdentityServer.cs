using Microsoft.AspNetCore.Authentication.JwtBearer;
using PathOrderManagement.Common.Auth;

namespace PathOrderManagement.Api.Configurations.Startup
{
    public static class ConfigureIdentityServer
    {
        public static IServiceCollection AddIdentityConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = JwtManager.ValidationParameters;
            });

            return services;
        }
    }
}

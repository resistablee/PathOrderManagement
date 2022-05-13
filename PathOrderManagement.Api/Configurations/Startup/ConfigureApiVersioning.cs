using Microsoft.AspNetCore.Mvc;

namespace PathOrderManagement.Api.Configurations.Startup
{
    public static class ConfigureApiVersioning
    {
        public static IServiceCollection AddApiVersioningConfigurations(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
            });

            return services;
        }

        public static IApplicationBuilder UseApiVersioningConfiguration(this IApplicationBuilder app)
        {
            app.UseApiVersioning();

            return app;
        }
    }
}

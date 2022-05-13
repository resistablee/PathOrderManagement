
namespace PathOrderManagement.Api.Configurations.Startup
{
    public static class ConfigureCORS
    {
        public static IServiceCollection AddCorsConfigurations(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin", options =>
                {
                    options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            return services;
        }

        public static IApplicationBuilder UseCorsConfiguration(this IApplicationBuilder app)
        {
            //app.UseCors("AllowOrigin");

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            return app;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PathOrderManagement.DataAccess;

namespace PathOrderManagement.Api.Configurations.Startup
{
    public static class ConfigureDbContext
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(x =>
            {
                x.UseLazyLoadingProxies();
                x.UseSqlServer(configuration.GetConnectionString("MSSQLConnectionString"));
            }, ServiceLifetime.Transient);

            return services;
        }
    }
}

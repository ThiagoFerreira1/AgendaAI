
using Microsoft.Extensions.DependencyInjection;

namespace Schedule.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString();
        }
    }
}

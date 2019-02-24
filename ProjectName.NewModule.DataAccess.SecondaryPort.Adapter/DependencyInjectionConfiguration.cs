using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.Adapter.DataAccess;
using $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.DataAccess.Interfaces;

namespace $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.Adapter
{
    public static class DependencyInjectionConfiguration
    {
        public static void Add$ext_NewModuleName$DataAccessSecondaryPort(this IServiceCollection serviceCollection, string connectionString)
        {
            Add$ext_NewModuleName$DataAccessRepository(serviceCollection);
            Add$ext_NewModuleName$DataAccessDbContext(serviceCollection, connectionString);
        }

        private static void Add$ext_NewModuleName$DataAccessRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(I$ext_NewModuleName$Repository<>), typeof($ext_NewModuleName$Repository<>));
        }

        private static void Add$ext_NewModuleName$DataAccessDbContext(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddScoped(_ => new $ext_NewModuleName$DbContext(connectionString));
        }
    }
}
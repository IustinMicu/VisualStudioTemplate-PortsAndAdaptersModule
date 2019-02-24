using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.Adapter.DataAccess;
using $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.DataAccess.Interfaces;

namespace $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.Adapter
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddNewModuleDataAccessSecondaryPort(this IServiceCollection serviceCollection, string connectionString)
        {
            AddNewModuleDataAccessRepository(serviceCollection);
            AddNewModuleDataAccessDbContext(serviceCollection, connectionString);
        }

        private static void AddNewModuleDataAccessRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(INewModuleRepository<>), typeof(NewModuleRepository<>));
        }

        private static void AddNewModuleDataAccessDbContext(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddScoped(_ => new NewModuleDbContext(connectionString));
        }
    }
}
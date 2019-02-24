using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.Adapter;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain;
using $ext_ApplicationName$.$ext_NewModuleName$.ExternalServicess.SecondaryPort.Adapter;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Adapter;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter;
using $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Adapter;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Bootstrap
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddNewModuleModule(this IServiceCollection serviceCollection, string connectionString)
        {
            // Secondary ports
            serviceCollection.AddNewModuleDataAccessSecondaryPort(connectionString);
            serviceCollection.AddNewModuleInteropSecondaryPort();
            serviceCollection.AddNewModuleExternalServicesSecondaryPort();

            // Domain
            serviceCollection.AddNewModuleDomain();

            // Primary ports
            serviceCollection.AddNewModuleWebPrimaryPort();
            serviceCollection.AddNewModuleInteropPrimaryPort();

            return serviceCollection;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.Adapter;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain;
using $ext_ApplicationName$.$ext_NewModuleName$.ExternalServices.SecondaryPort.Adapter;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Adapter;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter;
using $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Adapter;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Bootstrap
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection Add$ext_NewModuleName$Module(this IServiceCollection serviceCollection, string connectionString)
        {
            // Secondary ports
            serviceCollection.Add$ext_NewModuleName$DataAccessSecondaryPort(connectionString);
            serviceCollection.Add$ext_NewModuleName$InteropSecondaryPort();
            serviceCollection.Add$ext_NewModuleName$ExternalServicesSecondaryPort();

            // Domain
            serviceCollection.Add$ext_NewModuleName$Domain();

            // Primary ports
            serviceCollection.Add$ext_NewModuleName$WebPrimaryPort();
            serviceCollection.Add$ext_NewModuleName$InteropPrimaryPort();

            return serviceCollection;
        }
    }
}

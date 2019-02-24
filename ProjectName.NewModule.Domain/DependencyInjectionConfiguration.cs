using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain.DomainServices;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain.DomainServices.Interfaces;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Domain
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddNewModuleDomain(this IServiceCollection serviceCollection)
        {
            AddDomainServices(serviceCollection);
        }

        private static void AddDomainServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IDummyService, DummyService>();
        }
    }
}
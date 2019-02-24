using System;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.ExternalServices.SecondaryPort.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.ExternalServices.SecondaryPort.Adapter.Mappings;

namespace $ext_ApplicationName$.$ext_NewModuleName$.ExternalServices.SecondaryPort.Adapter
{
    public static class DependencyInjectionConfiguration
    {
        public static void Add$ext_NewModuleName$ExternalServicesSecondaryPort(this IServiceCollection serviceCollection)
        {
            Add$ext_NewModuleName$ExternalServicesManagers(serviceCollection);
            Add$ext_NewModuleName$ExternalServicesMappings(serviceCollection);
        }

        private static void Add$ext_NewModuleName$ExternalServicesManagers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IDummyExternalServiceManager, DummyExternalServiceManager>();
        }

        private static void Add$ext_NewModuleName$ExternalServicesMappings(IServiceCollection serviceCollection)
        {
            Mapper.AddProfile<$ext_NewModuleName$ExternalServicesProfile>();
        }
    }
}
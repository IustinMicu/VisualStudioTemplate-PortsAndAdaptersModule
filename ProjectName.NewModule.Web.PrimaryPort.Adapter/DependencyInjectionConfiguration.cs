using System;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Adapter.Mappings;
using $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Interfaces;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Adapter
{
    public static class DependencyInjectionConfiguration
    {
        public static void Add$ext_NewModuleName$WebPrimaryPort(this IServiceCollection serviceCollection)
        {
            Add$ext_NewModuleName$WebManagers(serviceCollection);
            Add$ext_NewModuleName$WebMappings(serviceCollection);
        }

        private static void Add$ext_NewModuleName$WebManagers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<I$ext_NewModuleName$WebManager, $ext_NewModuleName$WebManager>();
        }

        private static void Add$ext_NewModuleName$WebMappings(IServiceCollection serviceCollection)
        {
            Mapper.AddProfile<$ext_NewModuleName$WebDomainProfile>();
        }
    }
}

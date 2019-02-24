using System;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Adapter.Mappings;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Interfaces;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Adapter
{
    public static class DependencyInjectionConfiguration
    {
        public static void Add$ext_NewModuleName$InteropPrimaryPort(this IServiceCollection serviceCollection)
        {
            Add$ext_NewModuleName$InteropManagers(serviceCollection);
            Add$ext_NewModuleName$InteropMappings(serviceCollection);
        }

        private static void Add$ext_NewModuleName$InteropManagers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<I$ext_NewModuleName$InteropOtherModuleManager, $ext_NewModuleName$InteropOtherModuleManager>();
        }

        private static void Add$ext_NewModuleName$InteropMappings(IServiceCollection serviceCollection)
        {
            Mapper.AddProfile<$ext_NewModuleName$InteropDomainProfile>();
        }
    }
}

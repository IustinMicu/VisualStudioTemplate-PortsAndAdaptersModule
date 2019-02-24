using System;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter.Mappings;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Interfaces;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter
{
    public static class DependencyInjectionConfiguration
    {
        public static void Add$ext_NewModuleName$InteropSecondaryPort(this IServiceCollection serviceCollection)
        {
            AddInteropOtherModuleManagers(serviceCollection);
            AddInteropOtherModuleMappings(serviceCollection);

            // TODO: Remove
            serviceCollection.AddScoped<IOtherModuleInterop$ext_NewModuleName$Manager, OtherModuleInterop$ext_NewModuleName$Manager>();
        }

        private static void AddInteropOtherModuleManagers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IInteropOtherModuleManager, InteropOtherModuleManager>();
        }

        private static void AddInteropOtherModuleMappings(IServiceCollection serviceCollection)
        {
            Mapper.AddProfile<$ext_NewModuleName$DomainInteropProfile>();
        }
    }
}

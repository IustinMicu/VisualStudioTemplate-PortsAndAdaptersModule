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
        public static void AddNewModuleInteropSecondaryPort(this IServiceCollection serviceCollection)
        {
            AddInteropOtherModuleManagers(serviceCollection);
            AddInteropOtherModuleMappings(serviceCollection);

            // TODO: Remove
            serviceCollection.AddScoped<IOtherModuleInteropNewModuleManager, OtherModuleInteropNewModuleManager>();
        }

        private static void AddInteropOtherModuleManagers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IInteropOtherModuleManager, InteropOtherModuleManager>();
        }

        private static void AddInteropOtherModuleMappings(IServiceCollection serviceCollection)
        {
            //var profiles = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(Profile)));

            //foreach (var profile in profiles)
            //{
            //    Mapper.Initialize(cfg => cfg.AddProfile(Activator.CreateInstance(profile) as Profile));
            //}

            Mapper.AddProfile<NewModuleDomainInteropProfile>();
        }
    }
}

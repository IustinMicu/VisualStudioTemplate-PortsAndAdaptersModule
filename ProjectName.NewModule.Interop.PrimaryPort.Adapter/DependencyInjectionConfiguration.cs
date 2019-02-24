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
        public static void AddNewModuleInteropPrimaryPort(this IServiceCollection serviceCollection)
        {
            AddNewModuleInteropManagers(serviceCollection);
            AddNewModuleInteropMappings(serviceCollection);
        }

        private static void AddNewModuleInteropManagers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<INewModuleInteropOtherModuleManager, NewModuleInteropOtherModuleManager>();
        }

        private static void AddNewModuleInteropMappings(IServiceCollection serviceCollection)
        {
            //var profiles = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(Profile)));

            //foreach (var profile in profiles)
            //{
            //    Mapper.Initialize(cfg => cfg.AddProfile(Activator.CreateInstance(profile) as Profile));
            //}

            Mapper.AddProfile<NewModuleInteropDomainProfile>();
        }
    }
}

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
        public static void AddNewModuleExternalServicesecondaryPort(this IServiceCollection serviceCollection)
        {
            AddNewModuleExternalServicesManagers(serviceCollection);
            AddNewModuleExternalServicesMappings(serviceCollection);
        }

        private static void AddNewModuleExternalServicesManagers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IDummyExternalServiceManager, DummyExternalServiceManager>();
        }

        private static void AddNewModuleExternalServicesMappings(IServiceCollection serviceCollection)
        {
            //var profiles = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(Profile)));

            //foreach (var profile in profiles)
            //{
            //    Mapper.Initialize(cfg => cfg.AddProfile(Activator.CreateInstance(profile) as Profile));
            //}

            Mapper.AddProfile<NewModuleExternalServicesProfile>();
        }
    }
}
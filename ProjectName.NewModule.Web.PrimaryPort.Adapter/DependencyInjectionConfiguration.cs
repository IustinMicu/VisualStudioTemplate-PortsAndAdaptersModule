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
        public static void AddNewModuleWebPrimaryPort(this IServiceCollection serviceCollection)
        {
            AddNewModuleWebManagers(serviceCollection);
            AddNewModuleWebMappings(serviceCollection);
        }

        private static void AddNewModuleWebManagers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<INewModuleWebManager, NewModuleWebManager>();
        }

        private static void AddNewModuleWebMappings(IServiceCollection serviceCollection)
        {
            //var profiles = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(Profile)));

            //foreach (var profile in profiles)
            //{
            //    Mapper.Initialize(cfg => cfg.AddProfile(Activator.CreateInstance(profile) as Profile));
            //}

            Mapper.AddProfile<NewModuleWebDomainProfile>();
        }
    }
}

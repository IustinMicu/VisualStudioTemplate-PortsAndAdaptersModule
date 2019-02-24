using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain.DomainServices;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain.DomainServices.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Adapter
{
    public class NewModuleInteropOtherModuleManager : INewModuleInteropOtherModuleManager
    {
        private readonly IDummyService dummyService;

        public NewModuleInteropOtherModuleManager(IDummyService dummyService)
        {
            this.dummyService = dummyService;
        }

        public DummyModel Get()
        {
            var dummyEntity = this.dummyService.Get();
            var dummyModel = Mapper.Map<DummyModel>(dummyEntity);

            return dummyModel;
        }
    }
}
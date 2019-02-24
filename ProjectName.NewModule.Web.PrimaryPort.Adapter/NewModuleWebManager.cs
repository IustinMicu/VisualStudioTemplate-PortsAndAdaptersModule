using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain.DomainServices;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain.DomainServices.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Adapter
{
    public class $ext_NewModuleName$WebManager : I$ext_NewModuleName$WebManager
    {
        private readonly IDummyService dummyService;

        public $ext_NewModuleName$WebManager(IDummyService dummyService)
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
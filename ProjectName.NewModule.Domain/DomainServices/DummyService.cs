using $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.DataAccess.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Domain.DomainServices.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Entities;
using $ext_ApplicationName$.$ext_NewModuleName$.ExternalServices.SecondaryPort.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Interfaces;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Domain.DomainServices
{
    public class DummyService : IDummyService
    {
        private readonly INewModuleRepository<DummyEntity> repository;
        private readonly IInteropOtherModuleManager otherModuleManager;
        private readonly IDummyExternalServiceManager externalServiceManager;

        public DummyService(
            INewModuleRepository<DummyEntity> newModuleRepository,
            IInteropOtherModuleManager otherModuleManager,
            IDummyExternalServiceManager externalServiceManager)
        {
            this.repository = newModuleRepository;
            this.otherModuleManager = otherModuleManager;
            this.externalServiceManager = externalServiceManager;
        }

        public DummyEntity Get()
        {
            var dummyEntity = repository.GetSingleBy(_ => true);
            var dummyModelFromOtherInteropModule = otherModuleManager.Get();
            var dummyModelFromExternalService = externalServiceManager.Get();

            return dummyEntity;
        }
    }
}

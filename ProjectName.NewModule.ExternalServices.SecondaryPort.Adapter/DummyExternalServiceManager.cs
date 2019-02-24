using $ext_ApplicationName$.$ext_NewModuleName$.ExternalServices.SecondaryPort.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.ExternalServices.SecondaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.ExternalServices.SecondaryPort.Adapter
{
    public class DummyExternalServiceManager : IDummyExternalServiceManager
    {
        public DummyModel Get()
        {
            return new DummyModel
            {
                Name = "Dummy External service"
            };
        }
    }
}
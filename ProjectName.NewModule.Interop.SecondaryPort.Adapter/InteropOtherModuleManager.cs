using System.Collections.Generic;
using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter
{
    public class InteropOtherModuleManager : IInteropOtherModuleManager
    {
        private readonly IOtherModuleInteropNewModuleManager otherModuleInteropNewModuleManager;

        public InteropOtherModuleManager(IOtherModuleInteropNewModuleManager otherModuleInteropNewModuleManager)
        {
            this.otherModuleInteropNewModuleManager = otherModuleInteropNewModuleManager;
        }

        public DummyModel Get()
        {
            var dummyInterop = this.otherModuleInteropNewModuleManager.Get();
            var dummyModel = Mapper.Map<DummyModel>(dummyInterop);

            return dummyModel;
        }
    }
}
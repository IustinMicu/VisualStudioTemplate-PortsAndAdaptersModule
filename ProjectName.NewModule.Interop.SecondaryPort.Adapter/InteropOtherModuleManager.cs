using System.Collections.Generic;
using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter
{
    public class InteropOtherModuleManager : IInteropOtherModuleManager
    {
        private readonly IOtherModuleInterop$ext_NewModuleName$Manager otherModuleInterop$ext_NewModuleName$Manager;

        public InteropOtherModuleManager(IOtherModuleInterop$ext_NewModuleName$Manager otherModuleInterop$ext_NewModuleName$Manager)
        {
            this.otherModuleInterop$ext_NewModuleName$Manager = otherModuleInterop$ext_NewModuleName$Manager;
        }

        public DummyModel Get()
        {
            var dummyInterop = this.otherModuleInterop$ext_NewModuleName$Manager.Get();
            var dummyModel = Mapper.Map<DummyModel>(dummyInterop);

            return dummyModel;
        }
    }
}
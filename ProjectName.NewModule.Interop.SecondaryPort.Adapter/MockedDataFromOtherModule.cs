namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter
{
    // Mocks the actual manager from the remote 'Other' module
    // TODO: Remove
    public interface IOtherModuleInteropNewModuleManager
    {
        DummyInterop Get();
    }

    public class OtherModuleInteropNewModuleManager : IOtherModuleInteropNewModuleManager
    {
        public DummyInterop Get()
        {
            return new DummyInterop
            {
                Name = "Dummy Interop"
            };
        }
    }

    // Mocks the actual object that is requested from the remote 'Other' module
    // TODO: Remove
    public class DummyInterop
    {
        public string Name { get; set; }
    }
}
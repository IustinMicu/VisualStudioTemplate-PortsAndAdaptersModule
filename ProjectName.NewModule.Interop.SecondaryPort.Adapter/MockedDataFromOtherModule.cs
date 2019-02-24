namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter
{
    // Mocks the actual manager from the remote 'Other' module
    // TODO: Remove
    public interface IOtherModuleInterop$ext_NewModuleName$Manager
    {
        DummyInterop Get();
    }

    public class OtherModuleInterop$ext_NewModuleName$Manager : IOtherModuleInterop$ext_NewModuleName$Manager
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
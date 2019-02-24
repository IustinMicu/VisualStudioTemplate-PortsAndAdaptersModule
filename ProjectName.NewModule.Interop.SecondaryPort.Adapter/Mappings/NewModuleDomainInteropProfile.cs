using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter.Mappings
{
    public class NewModuleDomainInteropProfile : Profile
    {
        public NewModuleDomainInteropProfile()
        {
            Mapper.CreateMap<DummyInterop, DummyModel>()
                .ForMember(dest => dest.Name, op => op.MapFrom(src => src.Name));
        }
    }
}
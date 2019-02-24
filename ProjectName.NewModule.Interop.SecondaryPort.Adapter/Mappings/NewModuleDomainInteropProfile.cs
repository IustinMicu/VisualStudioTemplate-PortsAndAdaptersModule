using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.SecondaryPort.Adapter.Mappings
{
    public class $ext_NewModuleName$DomainInteropProfile : Profile
    {
        public $ext_NewModuleName$DomainInteropProfile()
        {
            Mapper.CreateMap<DummyInterop, DummyModel>()
                .ForMember(dest => dest.Name, op => op.MapFrom(src => src.Name));
        }
    }
}
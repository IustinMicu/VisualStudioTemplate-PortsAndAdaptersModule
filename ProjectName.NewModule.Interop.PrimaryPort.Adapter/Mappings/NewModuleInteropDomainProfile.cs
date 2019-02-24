using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Entities;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Adapter.Mappings
{
    public class $ext_NewModuleName$InteropDomainProfile : Profile
    {
        public $ext_NewModuleName$InteropDomainProfile()
        {
            Mapper.CreateMap<DummyEntity, DummyModel>()
                .ForMember(dest => dest.Name, op => op.MapFrom(src => src.Name));
        }
    }
}
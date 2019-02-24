using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Entities;
using $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Interop.PrimaryPort.Adapter.Mappings
{
    public class NewModuleInteropDomainProfile : Profile
    {
        public NewModuleInteropDomainProfile()
        {
            Mapper.CreateMap<DummyEntity, DummyModel>()
                .ForMember(dest => dest.Name, op => op.MapFrom(src => src.Name));
        }
    }
}
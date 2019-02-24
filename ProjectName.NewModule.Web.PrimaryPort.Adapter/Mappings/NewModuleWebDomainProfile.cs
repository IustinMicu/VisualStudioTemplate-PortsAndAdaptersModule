using AutoMapper;
using $ext_ApplicationName$.$ext_NewModuleName$.Entities;
using $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Models;

namespace $ext_ApplicationName$.$ext_NewModuleName$.Web.PrimaryPort.Adapter.Mappings
{
    public class $ext_NewModuleName$WebDomainProfile : Profile
    {
        public $ext_NewModuleName$WebDomainProfile()
        {
            Mapper.CreateMap<DummyEntity, DummyModel>()
                .ForMember(dest => dest.Name, op => op.MapFrom(src => src.Name));
        }
    }
}
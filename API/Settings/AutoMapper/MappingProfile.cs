using AutoMapper;
using Models;
using Models.DTO;

namespace Config.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUsuarioDTO, Usuario>().ReverseMap();
        CreateMap<ResponseUsuarioDTO, Usuario>().ReverseMap();
    }
}
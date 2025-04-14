using AutoMapper;
using Models;
using Models.Base;
using Models.Derivatives;
using Models.DTO;

namespace Config.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUsuarioDTO, Usuario>().ReverseMap();
        CreateMap<ResponseUsuarioDTO, Usuario>().ReverseMap();

        CreateMap<Joia, CreateJoiaDTO>().ReverseMap();
        CreateMap<Anel, CreateJoiaDTO>().ReverseMap();
        CreateMap<Brinco, CreateJoiaDTO>().ReverseMap();
        CreateMap<Colar, CreateJoiaDTO>().ReverseMap();
        CreateMap<Piercing, CreateJoiaDTO>().ReverseMap();
        CreateMap<Pingente, CreateJoiaDTO>().ReverseMap();
        CreateMap<Pulseira, CreateJoiaDTO>().ReverseMap();
        CreateMap<Relogio, CreateJoiaDTO>().ReverseMap();
    }
}
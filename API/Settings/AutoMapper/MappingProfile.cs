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
        CreateMap<CreateJoiaDTO, Joia>().ReverseMap();
        CreateMap<Anel, Joia>().ReverseMap();
        CreateMap<Brinco, Joia>().ReverseMap();
        CreateMap<Colar, Joia>().ReverseMap();
        CreateMap<Piercing, Joia>().ReverseMap();
        CreateMap<Pingente, Joia>().ReverseMap();
        CreateMap<Pulseira, Joia>().ReverseMap();
        CreateMap<Relogio, Joia>().ReverseMap();
    }
}
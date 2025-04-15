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

        CreateMap<CreateAnuncioDTO, Anuncio>().ReverseMap();
        CreateMap<ResponseAnuncioDTO, Anuncio>().ReverseMap();

        CreateMap<Joia, CreateJoiaDTO>().ReverseMap();
        CreateMap<Anel, CreateJoiaDTO>().ReverseMap();
        CreateMap<Brinco, CreateJoiaDTO>().ReverseMap();
        CreateMap<Colar, CreateJoiaDTO>().ReverseMap();
        CreateMap<Piercing, CreateJoiaDTO>().ReverseMap();
        CreateMap<Pingente, CreateJoiaDTO>().ReverseMap();
        CreateMap<Pulseira, CreateJoiaDTO>().ReverseMap();
        CreateMap<Relogio, CreateJoiaDTO>().ReverseMap();

        CreateMap<CreateJoiaDTO, EditJoiaDTO>().ReverseMap();

        CreateMap<Joia, EditJoiaDTO>().ReverseMap();
        CreateMap<Anel, EditJoiaDTO>().ReverseMap();
        CreateMap<Brinco, EditJoiaDTO>().ReverseMap();
        CreateMap<Colar, EditJoiaDTO>().ReverseMap();
        CreateMap<Piercing, EditJoiaDTO>().ReverseMap();
        CreateMap<Pingente, EditJoiaDTO>().ReverseMap();
        CreateMap<Pulseira, EditJoiaDTO>().ReverseMap();
        CreateMap<Relogio, EditJoiaDTO>().ReverseMap();
    }
}
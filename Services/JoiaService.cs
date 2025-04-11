using AutoMapper;
using DAO.Interfaces;
using Models.Base;
using Models.Derivatives;
using Models.DTO;
using Services.Interfaces;

namespace Services;

public class JoiaService : IJoiaService
{
    private readonly IJoiaRepository _joiaRepository;
    private readonly IMapper _mapper;

    public JoiaService(IJoiaRepository joiaRepository, IMapper mapper)
    {
        _joiaRepository = joiaRepository;
        _mapper = mapper;
    }
    public async Task Post(CreateJoiaDTO joiaDTO)
    {
        Joia joia = _mapper.Map<Joia>(joiaDTO);
        joia = ReturnPart(joia);

        await _joiaRepository.Post(joia);
    }

    public async Task<List<Joia>> Get()
    {
        return await _joiaRepository.Get();
    }

    public async Task<Joia?> GetById(String id)
    {
        return await _joiaRepository.GetById(id);
    }

    public async Task Put(Joia joia)
    {
        await _joiaRepository.Put(joia);
    }

    public async Task Delete(String id)
    {
        await _joiaRepository.Delete(id);
    }

    private Joia ReturnPart(Joia joia)
    {
        switch (joia.TipoPeca)
        {
            case "Anel":
                Anel anel = _mapper.Map<Anel>(joia);
                return anel;
            case "Brinco":
                Brinco brinco = _mapper.Map<Brinco>(joia);
                return brinco;
            case "Colar":
                Colar colar = _mapper.Map<Colar>(joia);
                return colar;
            case "Piercing":
                Piercing piercing = _mapper.Map<Piercing>(joia);
                return piercing; ;
            case "Pingente":
                Pingente pingente = _mapper.Map<Pingente>(joia);
                return pingente;
            case "Pulseira":
                Pulseira pulseira = _mapper.Map<Pulseira>(joia);
                return pulseira;
            case "Relogio":
                Relogio relogio = _mapper.Map<Relogio>(joia);
                return relogio;
            default:
                return joia;
        }
    }
}
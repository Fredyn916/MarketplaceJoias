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

    public async Task<String> Post(CreateJoiaDTO joiaDTO)
    {
        var peca = ReturnPartPOST(joiaDTO);

        return await _joiaRepository.Post(peca);
    }

    public async Task<List<Joia>> Get()
    {
        return await _joiaRepository.Get();
    }

    public async Task<Joia?> GetById(String id)
    {
        return await _joiaRepository.GetById(id);
    }

    public async Task Put(EditJoiaDTO joiaDTO)
    {
        var peca = ReturnPartPUT(joiaDTO);

        await _joiaRepository.Put(peca);
    }

    public async Task Delete(String id)
    {
        await _joiaRepository.Delete(id);
    }

    private Joia ReturnPartPOST(CreateJoiaDTO joiaDTO)
    {
        switch (joiaDTO.TipoPeca)
        {
            case "Anel":
                Anel anel = _mapper.Map<Anel>(joiaDTO);
                return anel;
            case "Brinco":
                Brinco brinco = _mapper.Map<Brinco>(joiaDTO);
                return brinco;
            case "Colar":
                Colar colar = _mapper.Map<Colar>(joiaDTO);
                return colar;
            case "Piercing":
                Piercing piercing = _mapper.Map<Piercing>(joiaDTO);
                return piercing; ;
            case "Pingente":
                Pingente pingente = _mapper.Map<Pingente>(joiaDTO);
                return pingente;
            case "Pulseira":
                Pulseira pulseira = _mapper.Map<Pulseira>(joiaDTO);
                return pulseira;
            case "Relogio":
                Relogio relogio = _mapper.Map<Relogio>(joiaDTO);
                return relogio;
            default:
                return _mapper.Map<Joia>(joiaDTO);
        }
    }

    private Joia ReturnPartPUT(EditJoiaDTO joiaDTO)
    {
        switch (joiaDTO.TipoPeca)
        {
            case "Anel":
                Anel anel = _mapper.Map<Anel>(joiaDTO);
                return anel;
            case "Brinco":
                Brinco brinco = _mapper.Map<Brinco>(joiaDTO);
                return brinco;
            case "Colar":
                Colar colar = _mapper.Map<Colar>(joiaDTO);
                return colar;
            case "Piercing":
                Piercing piercing = _mapper.Map<Piercing>(joiaDTO);
                return piercing; ;
            case "Pingente":
                Pingente pingente = _mapper.Map<Pingente>(joiaDTO);
                return pingente;
            case "Pulseira":
                Pulseira pulseira = _mapper.Map<Pulseira>(joiaDTO);
                return pulseira;
            case "Relogio":
                Relogio relogio = _mapper.Map<Relogio>(joiaDTO);
                return relogio;
            default:
                return _mapper.Map<Joia>(joiaDTO);
        }
    }
}
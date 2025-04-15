using AutoMapper;
using DAO.Interfaces;
using Models.DTO;
using Models;
using Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Services;

public class AnuncioService : IAnuncioService
{
    private readonly IAnuncioRepository _anuncioRepository;
    private readonly IMapper _mapper;

    public AnuncioService(IAnuncioRepository anuncioRepository, IMapper mapper)
    {
        _anuncioRepository = anuncioRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateAnuncioDTO anuncioDTO)
    {
        Anuncio anuncio = _mapper.Map<Anuncio>(anuncioDTO);

        await _anuncioRepository.Post(anuncio);
    }

    public async Task<List<ResponseAnuncioDTO>> Get()
    {
        return await _anuncioRepository.Get();
    }

    public async Task<ResponseAnuncioDTO?> GetById(int id)
    {
        return await _anuncioRepository.GetById(id);
    }

    public async Task Put(Anuncio anuncio)
    {
        await _anuncioRepository.Put(anuncio);
    }

    public async Task Delete(int id)
    {
        await _anuncioRepository.Delete(id);
    }

    public async Task<List<String>> UploadImages(List<IFormFile> files)
    {
        return await _anuncioRepository.UploadImages(files);
    }
}
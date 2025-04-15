using AutoMapper;
using Models.DTO;
using Models;
using Supabase;
using DAO.Interfaces;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Http;

namespace DAO;

public class AnuncioRepository : IAnuncioRepository
{
    private readonly Client _client;
    private readonly Cloudinary _cloudinary;
    private readonly IMapper _mapper;

    public AnuncioRepository(Client client, Cloudinary cloudinary, IMapper mapper)
    {
        _client = client;
        _cloudinary = cloudinary;
        _mapper = mapper;
    }

    public async Task Post(Anuncio anuncio)
    {
        await _client.From<Anuncio>().Insert(anuncio);
    }

    public async Task<List<ResponseAnuncioDTO>> Get()
    {
        List<ResponseAnuncioDTO> anuncios = new List<ResponseAnuncioDTO>();

        var response = await _client.From<Anuncio>().Get();

        foreach (var item in response.Models)
        {
            anuncios.Add(_mapper.Map<ResponseAnuncioDTO>(item));
        }
        return anuncios;
    }

    public async Task<ResponseAnuncioDTO?> GetById(int id)
    {
        var response = await _client.From<Anuncio>()
            .Filter("id", Supabase.Postgrest.Constants.Operator.Equals, id)
            .Get();

        ResponseAnuncioDTO anuncio = _mapper.Map<ResponseAnuncioDTO>(response.Models.First());
        return anuncio;
    }

    public async Task Put(Anuncio anuncio)
    {
        await _client.From<Anuncio>().Update(anuncio);
    }

    public async Task Delete(int id)
    {
        var anuncio = _mapper.Map<Anuncio>(GetById(id).Result);
        await _client.From<Anuncio>().Delete(anuncio);
    }

    public async Task<List<String>> UploadImages(List<IFormFile> files)
    {
        var imageUrls = new List<String>();

        foreach (var file in files)
        {
            if (file.Length > 0)
            {
                await using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    UseFilename = true,
                    UniqueFilename = false,
                    Overwrite = true,
                    Folder = "ImagensJoias" // Pasta na nuvem
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);
                imageUrls.Add(uploadResult.SecureUrl.ToString());
            }
        }

        return imageUrls;
    }
}
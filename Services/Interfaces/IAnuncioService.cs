using Models.DTO;
using Models;
using Microsoft.AspNetCore.Http;

namespace Services.Interfaces;

public interface IAnuncioService
{
    Task Post(CreateAnuncioDTO anuncioDTO);
    Task<List<ResponseAnuncioDTO>> Get();
    Task<ResponseAnuncioDTO?> GetById(int id);
    Task Put(Anuncio anuncio);
    Task Delete(int id);
    Task<List<String>> UploadImages(List<IFormFile> files);
}
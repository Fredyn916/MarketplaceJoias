using Microsoft.AspNetCore.Http;
using Models;
using Models.DTO;

namespace DAO.Interfaces;

public interface IAnuncioRepository
{
    Task Post(Anuncio anuncio);
    Task<List<ResponseAnuncioDTO>> Get();
    Task<ResponseAnuncioDTO?> GetById(int id);
    Task Put(Anuncio anuncio);
    Task Delete(int id);
    Task<List<String>> UploadImages(List<IFormFile> files);
}
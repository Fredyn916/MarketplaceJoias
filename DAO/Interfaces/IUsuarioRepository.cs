using Microsoft.AspNetCore.Http;
using Models;
using Models.DTO;

namespace DAO.Interfaces;

public interface IUsuarioRepository
{
    Task<ResponseUsuarioDTO> Post(Usuario user);
    Task<List<ResponseUsuarioDTO>> Get();
    Task<ResponseUsuarioDTO?> GetById(int id);
    Task Put(Usuario user);
    Task Delete(int id);
    Task<ResponseUsuarioDTO> Login(String email, String password);
    Task UploadImage(IFormFile file, int usuarioId);
}
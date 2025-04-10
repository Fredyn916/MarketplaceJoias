using Models;
using Models.DTO;

namespace Services.Interfaces;

public interface IUsuarioService
{
    Task<ResponseUsuarioDTO> Post(Usuario user);
    Task<List<ResponseUsuarioDTO>> Get();
    Task<ResponseUsuarioDTO?> GetById(int id);
    Task Put(Usuario user);
    Task Delete(int id);
    Task<ResponseUsuarioDTO> Login(String email, String password);
}
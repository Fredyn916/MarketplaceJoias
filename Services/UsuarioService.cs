using AutoMapper;
using DAO.Interfaces;
using Microsoft.AspNetCore.Http;
using Models;
using Models.DTO;
using Services.Interfaces;

namespace Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
    {
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
    }

    public async Task<ResponseUsuarioDTO> Post(CreateUsuarioDTO usuarioDTO)
    {
        Usuario usuario = _mapper.Map<Usuario>(usuarioDTO);

        return await _usuarioRepository.Post(usuario);
    }

    public async Task<List<ResponseUsuarioDTO>> Get()
    {
        return await _usuarioRepository.Get();
    }

    public async Task<ResponseUsuarioDTO?> GetById(int id)
    {
        return await _usuarioRepository.GetById(id);
    }

    public async Task Put(Usuario usuario)
    {
        await _usuarioRepository.Put(usuario);
    }

    public async Task Delete(int id)
    {
        await _usuarioRepository.Delete(id);
    }

    public async Task<ResponseUsuarioDTO> Login(String email, String password)
    {
        return await _usuarioRepository.Login(email, password);
    }

    public async Task UploadImage(IFormFile file, int usuarioId)
    {
        await _usuarioRepository.UploadImage(file, usuarioId);
    }
}
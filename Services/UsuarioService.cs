﻿using DAO.Interfaces;
using Models;
using Models.DTO;
using Services.Interfaces;

namespace Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<ResponseUsuarioDTO> Post(Usuario usuario)
    {
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
}
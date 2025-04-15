using AutoMapper;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using DAO.Interfaces;
using Microsoft.AspNetCore.Http;
using Models;
using Models.DTO;
using Supabase;

namespace DAO;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly Client _client;
    private readonly Cloudinary _cloudinary;
    private readonly IMapper _mapper;

    public UsuarioRepository(Client client, Cloudinary cloudinary, IMapper mapper)
    {
        _client = client;
        _cloudinary = cloudinary;
        _mapper = mapper;
    }

    public async Task<ResponseUsuarioDTO> Post(Usuario user)
    {
        var response = await _client.From<Usuario>().Insert(user);
        
        ResponseUsuarioDTO usuario = _mapper.Map<ResponseUsuarioDTO>(response.Models.First());
        return usuario;
    }

    public async Task<List<ResponseUsuarioDTO>> Get()
    {
        List<ResponseUsuarioDTO> usuarios = new List<ResponseUsuarioDTO>();

        var response = await _client.From<Usuario>().Get();

        foreach (var item in response.Models)
        {
            usuarios.Add(_mapper.Map<ResponseUsuarioDTO>(item));
        }
        return usuarios;
    }

    public async Task<ResponseUsuarioDTO?> GetById(int id)
    {
        var response = await _client.From<Usuario>()
            .Filter("id", Supabase.Postgrest.Constants.Operator.Equals, id)
            .Get();

        ResponseUsuarioDTO usuario = _mapper.Map<ResponseUsuarioDTO>(response.Models.First());
        return usuario;
    }

    public async Task Put(Usuario user)
    {
        await _client.From<Usuario>().Update(user);
    }

    public async Task Delete(int id)
    {
        var user = _mapper.Map<Usuario>(GetById(id).Result);
        await _client.From<Usuario>().Delete(user);
    }

    public async Task<ResponseUsuarioDTO> Login(String email, String password)
    {
        foreach (var item in Get().Result)
        {
            if (item.Email == email && item.Password == password)
            {
                return item;
            }
        }
        return null;
    }

    public async Task UploadImage(IFormFile file, int usuarioId)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("Arquivo inválido.");

        await using var stream = file.OpenReadStream();
        var uploadParams = new ImageUploadParams
        {
            File = new FileDescription(file.FileName, stream),
            UseFilename = true,
            UniqueFilename = false,
            Overwrite = true,
            Folder = "FotosPerfil" // Pasta na nuvem
        };

        var uploadResult = await _cloudinary.UploadAsync(uploadParams);

        Usuario user = _mapper.Map<Usuario>(GetById(usuarioId).Result);
        user.FotoPerfilURL = uploadResult.SecureUrl.ToString();

        await Put(user);
    }
}
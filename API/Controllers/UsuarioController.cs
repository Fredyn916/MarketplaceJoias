using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Services;
using Services.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
        
    }

    [HttpPost("PostUsuario")]
    public async Task<ResponseUsuarioDTO> Post(CreateUsuarioDTO usuarioDTO)
    {
        try
        {
            return await _usuarioService.Post(usuarioDTO);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetUsuario")]
    public async Task<List<ResponseUsuarioDTO>> Get()
    {
        try
        {
            return await _usuarioService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdUsuario")]
    public async Task<ResponseUsuarioDTO?> GetById(int id)
    {
        try
        {
            return await _usuarioService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutUsuario")]
    public async Task<IActionResult> Put(Usuario usuario)
    {
        try
        {
            await _usuarioService.Put(usuario);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteUsuario")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _usuarioService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("LoginUsuario")]
    public async Task<ResponseUsuarioDTO> Login(String email, String password)
    {
        try
        {
            var user = await _usuarioService.Login(email, password);

            if (user != null) return user;
            else throw new Exception();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPost("UploadImageUsuario")]
    public async Task<IActionResult> UploadImage(IFormFile file, int usuarioId)
    {
        try
        {
            await _usuarioService.UploadImage(file, usuarioId);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models;
using Services.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnuncioController : ControllerBase
{
    private readonly IAnuncioService _anuncioService;

    public AnuncioController(IAnuncioService anuncioService)
    {
        _anuncioService = anuncioService;
    }

    [HttpPost("PostAnuncio")]
    public async Task Post(CreateAnuncioDTO anuncioDTO)
    {
        try
        {
            await _anuncioService.Post(anuncioDTO);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetAnuncio")]
    public async Task<List<ResponseAnuncioDTO>> Get()
    {
        try
        {
            return await _anuncioService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdAnuncio")]
    public async Task<ResponseAnuncioDTO?> GetById(int id)
    {
        try
        {
            return await _anuncioService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutAnuncio")]
    public async Task<IActionResult> Put(Anuncio anuncio)
    {
        try
        {
            await _anuncioService.Put(anuncio);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteAnuncio")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _anuncioService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("UploadImagesAnuncio")]
    public async Task<List<String>> UploadImages(List<IFormFile> files)
    {
        try
        {
            return await _anuncioService.UploadImages(files);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
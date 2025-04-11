using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Services.Interfaces;
using Models.Base;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JoiaController : ControllerBase
{
    private readonly IJoiaService _joiaService;

    public JoiaController(IJoiaService joiaService)
    {
        _joiaService = joiaService;
    }

    [HttpPost("PostJoia")]
    public async Task<IActionResult> Post(CreateJoiaDTO joiaDTO)
    {
        try
        {
            await _joiaService.Post(joiaDTO);
            return Created();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetJoia")]
    public async Task<List<Joia>> Get()
    {
        try
        {
            return await _joiaService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdJoia")]
    public async Task<Joia?> GetById(String id)
    {
        try
        {
            return await _joiaService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutJoia")]
    public async Task<IActionResult> Put(Joia joia)
    {
        try
        {
            await _joiaService.Put(joia);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteJoia")]
    public async Task<IActionResult> Delete(String id)
    {
        try
        {
            await _joiaService.Delete(id);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
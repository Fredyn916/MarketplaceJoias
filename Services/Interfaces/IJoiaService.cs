using Models.Base;
using Models.DTO;

namespace Services.Interfaces;

public interface IJoiaService
{
    Task Post(CreateJoiaDTO joiaDTO);
    Task<List<Joia>> Get();
    Task<Joia?> GetById(String id);
    Task Put(EditJoiaDTO joiaDTO);
    Task Delete(String id);
}
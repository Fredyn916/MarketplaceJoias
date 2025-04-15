using Models.Base;

namespace DAO.Interfaces;

public interface IJoiaRepository
{
    Task<String> Post(Joia joia);
    Task<List<Joia>> Get();
    Task<Joia?> GetById(String id);
    Task Put(Joia joia);
    Task Delete(String id);
}
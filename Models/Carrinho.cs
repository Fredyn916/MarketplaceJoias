using Models.Base;

namespace Models;

public class Carrinho
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public List<Joia> Joias { get; set; }
}
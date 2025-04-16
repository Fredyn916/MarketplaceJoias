using Models.Base;

namespace Models;

public class Carrinho
{
    public int Id { get; set; }
    public int UsuarioId { get; set; } // Indica de qual usuário é o carrinho
    public List<Anuncio> AnunciosId { get; set; } // Anúncios que foram adicionados ao carrinho
}
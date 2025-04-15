namespace Models.DTO;

public class CreateAnuncioDTO
{
    public String Titulo { get; set; }
    public List<String> URLs { get; set; } // URL's das imagens do anúncio da joia anunciada
    public String JoiaId { get; set; }
    public int UsuarioId { get; set; }
}
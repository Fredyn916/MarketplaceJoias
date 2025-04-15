using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Models;

[Table("anuncios")]
public class Anuncio : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    [Column("titulo")]
    public String Titulo { get; set; }
    [Column("urls")]
    public List<String> URLs { get; set; } // URL's das imagens do anúncio da joia anunciada
    [Column("joia_id")]
    public String JoiaId { get; set; }
    [Column("usuario_id")]
    public int UsuarioId { get; set; }
}
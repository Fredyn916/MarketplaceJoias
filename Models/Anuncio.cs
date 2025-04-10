using Supabase.Postgrest.Attributes;

namespace Models;

[Table("usuarios")]
public class Anuncio
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    [Column("titulo")]
    public String Titulo { get; set; }
    [Column("urls")]
    public List<String> URLs { get; set; } // URL's das imagens do anúncio da joia anunciada
    [Column("joia_id")]
    public String JoiaId { get; set; } // CONFERIR O TIPO DO ID DO MONGO ATLAS
    [Column("usuario_id")]
    public int UsuarioId { get; set; }
}
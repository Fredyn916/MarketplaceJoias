using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Models;

[Table("usuarios")]
public class Usuario : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    [Column("nome")]
    public String Nome { get; set; }
    [Column("cpf")]
    public String CPF { get; set; }
    [Column("idade")]
    public int Idade { get; set; }
    [Column("email")]
    public String Email { get; set; }
    [Column("password")]
    public String Password { get; set; }
    [Column("cep")]
    public String CEP { get; set; }
    [Column("numero")]
    public int Numero { get; set; } // Casa, Apartamento, Prédio, etc...
    [Column("endereco")]
    public String Endereco { get; set; } // Rua, Nº (Complemento), Bairro, Cidade, Estado - CEP
    [Column("foto_perfil_url")]
    public String FotoPerfilURL { get; set; }
}
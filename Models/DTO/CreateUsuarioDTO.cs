namespace Models.DTO;

public class CreateUsuarioDTO
{
    public String Nome { get; set; }
    public String CPF { get; set; }
    public int Idade { get; set; }
    public String Email { get; set; }
    public String Password { get; set; }
    public String CEP { get; set; }
    public int Numero { get; set; } // Casa, Apartamento, Prédio, etc...
    public String Endereco { get; set; } // Rua, Nº (Complemento), Bairro, Cidade, Estado - CEP
}
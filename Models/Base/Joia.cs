namespace Models.Base;

public class Joia
{
    public double Valor { get; set; }
    public double Peso { get; set; }
    public String Material { get; set; }
    public String Tipo { get; set; } // Expresso pelo tipo das classes derivadas
    public String Descricao { get; set; }
    public List<String> URLs { get; set; } // URL's das imagens do anúncio da jóia
}
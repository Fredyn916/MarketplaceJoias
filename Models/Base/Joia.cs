namespace Models.Base;

public class Joia
{
    public double Valor { get; set; } // Em reais (R$)
    public String Descricao { get; set; }
    public double Peso { get; set; } // Em gramas (g)
    public String Material { get; set; }
    public double isStudded { get; set; }
    public String? MaterialCravejado { get; set; } // Ex: Diamante, Safira, etc...
}
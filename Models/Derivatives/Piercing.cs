using Models.Base;

namespace Models.Derivatives;

public class Piercing : Joia
{
    public String Regiao { get; set; } // Ex: Nariz, Orelha, Umbigo...
    public String Fechamento { get; set; } // Ex: Encaixe, Rosca...
    public double Tamanho { get; set; } // Em milímetros (mm). Dimensão da joia
    public bool isAntiallergic { get; set; }
}
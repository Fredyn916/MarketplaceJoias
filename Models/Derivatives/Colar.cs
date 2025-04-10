using Models.Base;

namespace Models.Derivatives;

public class Colar : Joia
{
    public int Comprimento { get; set; } // Em centímetros (cm)
    public double Espessura { get; set; } // Em milímetros (mm)
    public bool havePendant { get; set; }
    public String Modelo { get; set; } // Ex: Gola, Longo, Choker, Cordão...
    public String TipoCorrente { get; set; } // Ex: Veneziana, Cartier...
}
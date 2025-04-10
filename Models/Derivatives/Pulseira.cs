using Models.Base;

namespace Models.Derivatives;

public class Pulseira : Joia
{
    public String TipoFecho { get; set; } // Ex: Ímã, Ajustável...
    public int Comprimento { get; set; } // Em centímetros (cm)
    public double Espessura { get; set; } // Em milímetros (mm)
    public bool haveCharms { get; set; }
    public String Flexibilidade { get; set; } // Ex: Rígida ou Maleável
}
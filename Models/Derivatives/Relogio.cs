using Models.Base;

namespace Models.Derivatives;

public class Relogio : Joia
{
    public String TipoMovimento { get; set; } // Ex: Quartz, Mecânico...
    public bool haveWaterResistance { get; set; }
    public double DiametroCaixa { get; set; } // Em milímetros (mm). Tamanho do mostrador
    public String MaterialPulseira { get; set; } // Ex: Couro, Metal...
    public String FonteEnergia {  get; set; } // Ex: Bateria, Solar...
}
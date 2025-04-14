namespace Models.DTO;

public class EditJoiaDTO
{
    public String Id { get; set; } // Object Id
    public String TipoPeca { get; set; } // Tipo de peça. Ex: Anél, Brinco, Colar, etc...
    public double Valor { get; set; } // Em reais (R$)
    public String Descricao { get; set; }
    public double Peso { get; set; } // Em gramas (g)
    public String Material { get; set; }
    public bool isStudded { get; set; }
    public String? MaterialCravejado { get; set; } // Ex: Diamante, Safira, etc...

    // Anel
    public int Tamanho { get; set; } // Ex: 16 (medida do aro)
    public String Formato { get; set; } // Ex: Solitário, Aliança, etc...

    // Brinco
    public String TipoFecho { get; set; } // Ex: Tarraxa, Gancho, Pressão...
    public String Modelo { get; set; } // Ex: Argola, Pendente...
    public double Altura { get; set; } // Em centímetros (cm)
    public double PesoIndividual { get; set; } // Em gramas (g)

    // Colar
    public int Comprimento { get; set; } // Em centímetros (cm)
    public double Espessura { get; set; } // Em milímetros (mm)
    public bool havePendant { get; set; }
    // public String Modelo { get; set; } // Ex: Gola, Longo, Choker, Cordão...
    public String TipoCorrente { get; set; } // Ex: Veneziana, Cartier...

    // Piercing
    public String Regiao { get; set; } // Ex: Nariz, Orelha, Umbigo...
    public String Fechamento { get; set; } // Ex: Encaixe, Rosca...
    // public double Tamanho { get; set; } // Em milímetros (mm). Dimensão da joia
    public bool isAntiallergic { get; set; }

    // Pingente
    // public String Formato { get; set; } // Ex: Coração, Cruz, Geométrico...

    // Pulseira
    // public String TipoFecho { get; set; } // Ex: Ímã, Ajustável...
    //public int Comprimento { get; set; } // Em centímetros (cm)
    // public double Espessura { get; set; } // Em milímetros (mm)
    public bool haveCharms { get; set; }
    public String Flexibilidade { get; set; } // Ex: Rígida ou Maleável

    // Relogio
    public String TipoMovimento { get; set; } // Ex: Quartz, Mecânico...
    public bool haveWaterResistance { get; set; }
    public double DiametroCaixa { get; set; } // Em milímetros (mm). Tamanho do mostrador
    public String MaterialPulseira { get; set; } // Ex: Couro, Metal...
    public String FonteEnergia { get; set; } // Ex: Bateria, Solar...
}
using Models.Base;

namespace Models.Derivatives;

public class Brinco : Joia
{
    public String TipoFecho { get; set; } // Ex: Tarraxa, Gancho, Pressão...
    public String Modelo { get; set; } // Ex: Argola, Pendente...
    public double Altura { get; set; } // Em centímetros (cm)
    public double PesoIndividual { get; set; } // Em gramas (g)
}
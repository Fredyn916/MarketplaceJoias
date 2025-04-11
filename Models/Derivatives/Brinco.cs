using Models.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Derivatives;

public class Brinco : Joia
{
    [BsonElement("tipo_fecho")]
    public String TipoFecho { get; set; } // Ex: Tarraxa, Gancho, Pressão...
    [BsonElement("modelo")]
    public String Modelo { get; set; } // Ex: Argola, Pendente...
    [BsonElement("altura")]
    public double Altura { get; set; } // Em centímetros (cm)
    [BsonElement("peso_individual")]
    public double PesoIndividual { get; set; } // Em gramas (g)
}
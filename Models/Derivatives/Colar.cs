using Models.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Derivatives;

[BsonDiscriminator("Colar")]
public class Colar : Joia
{
    [BsonElement("comprimento")]
    public int Comprimento { get; set; } // Em centímetros (cm)
    [BsonElement("espessura")]
    public double Espessura { get; set; } // Em milímetros (mm)
    [BsonElement("have_pendant")]
    public bool havePendant { get; set; }
    [BsonElement("modelo")]
    public String Modelo { get; set; } // Ex: Gola, Longo, Choker, Cordão...
    [BsonElement("tipo_corrente")]
    public String TipoCorrente { get; set; } // Ex: Veneziana, Cartier...
}
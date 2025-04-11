using Models.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Derivatives;

public class Pulseira : Joia
{
    [BsonElement("tipo_fecho")]
    public String TipoFecho { get; set; } // Ex: Ímã, Ajustável...
    [BsonElement("comprimento")]
    public int Comprimento { get; set; } // Em centímetros (cm)
    [BsonElement("espessura")]
    public double Espessura { get; set; } // Em milímetros (mm)
    [BsonElement("have_charms")]
    public bool haveCharms { get; set; }
    [BsonElement("flexibilidade")]
    public String Flexibilidade { get; set; } // Ex: Rígida ou Maleável
}
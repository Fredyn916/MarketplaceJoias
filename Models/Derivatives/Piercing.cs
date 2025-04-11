using Models.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Derivatives;

public class Piercing : Joia
{
    [BsonElement("regiao")]
    public String Regiao { get; set; } // Ex: Nariz, Orelha, Umbigo...
    [BsonElement("fechamento")]
    public String Fechamento { get; set; } // Ex: Encaixe, Rosca...
    [BsonElement("tamanho")]
    public double Tamanho { get; set; } // Em milímetros (mm). Dimensão da joia
    [BsonElement("is_antiallergic")]
    public bool isAntiallergic { get; set; }
}
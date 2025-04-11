using Models.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Derivatives;

[BsonDiscriminator("Anel")]
public class Anel : Joia
{
    [BsonElement("tamanho")]
    public int Tamanho { get; set; } // Ex: 16 (medida do aro)
    [BsonElement("formato")]
    public String Formato { get; set; } // Ex: Solitário, Aliança, etc...
}
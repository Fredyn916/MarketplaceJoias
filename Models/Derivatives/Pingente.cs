using Models.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Derivatives;

[BsonDiscriminator("Pingente")]
public class Pingente : Joia
{
    [BsonElement("formato")]
    public String Formato { get; set; } // Ex: Coração, Cruz, Geométrico...
}
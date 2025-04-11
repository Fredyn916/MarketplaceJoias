using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Models.Derivatives;

namespace Models.Base;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes(typeof(Anel), typeof(Brinco), typeof(Colar), typeof(Piercing), typeof(Pingente), typeof(Pulseira), typeof(Relogio))]
public class Joia
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public String Id { get; set; }
    [BsonElement("tipo_peca")]
    public String TipoPeca { get; set; } // Tipo de peça. Ex: Anél, Brinco, Colar, etc...
    [BsonElement("valor")]
    public double Valor { get; set; } // Em reais (R$)
    [BsonElement("descricao")]
    public String Descricao { get; set; }
    [BsonElement("peso")]
    public double Peso { get; set; } // Em gramas (g)
    [BsonElement("material")]
    public String Material { get; set; }
    [BsonElement("is_studded")]
    public bool isStudded { get; set; }
    [BsonElement("material_cravejado")]
    public String? MaterialCravejado { get; set; } // Ex: Diamante, Safira, etc...
}
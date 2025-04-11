using Models.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Derivatives;

public class Relogio : Joia
{
    [BsonElement("tipo_movimento")]
    public String TipoMovimento { get; set; } // Ex: Quartz, Mecânico...
    [BsonElement("have_waterResistance")]
    public bool haveWaterResistance { get; set; }
    [BsonElement("diametro_caixa")]
    public double DiametroCaixa { get; set; } // Em milímetros (mm). Tamanho do mostrador
    [BsonElement("material_pulseira")]
    public String MaterialPulseira { get; set; } // Ex: Couro, Metal...
    [BsonElement("fonte_energia")]
    public String FonteEnergia {  get; set; } // Ex: Bateria, Solar...
}
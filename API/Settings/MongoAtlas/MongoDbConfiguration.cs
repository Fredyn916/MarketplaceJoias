using Models.Base;
using Models.Derivatives;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization;

namespace API.Settings.MongoAtlas;

public static class MongoDbConfiguration
{
    public static void Configure()
    {
        // Ativar convenção de discriminator (tipo _t no MongoDB)
        var pack = new ConventionPack();
        ConventionRegistry.Register("CustomDiscriminatorConvention", pack, _ => true);

        // Registro da classe base
        if (!BsonClassMap.IsClassMapRegistered(typeof(Joia)))
        {
            BsonClassMap.RegisterClassMap<Joia>(cm =>
            {
                cm.AutoMap();
                cm.SetIsRootClass(true);
                cm.SetDiscriminator("Joia");
            });
        }

        // Registros dos tipos derivados
        if (!BsonClassMap.IsClassMapRegistered(typeof(Anel)))
        {
            BsonClassMap.RegisterClassMap<Anel>(cm =>
            {
                cm.AutoMap();
                cm.SetDiscriminator("Anel");
            });
        }

        if (!BsonClassMap.IsClassMapRegistered(typeof(Brinco)))
        {
            BsonClassMap.RegisterClassMap<Brinco>(cm =>
            {
                cm.AutoMap();
                cm.SetDiscriminator("Brinco");
            });
        }

        if (!BsonClassMap.IsClassMapRegistered(typeof(Colar)))
        {
            BsonClassMap.RegisterClassMap<Colar>(cm =>
            {
                cm.AutoMap();
                cm.SetDiscriminator("Colar");
            });
        }

        if (!BsonClassMap.IsClassMapRegistered(typeof(Piercing)))
        {
            BsonClassMap.RegisterClassMap<Piercing>(cm =>
            {
                cm.AutoMap();
                cm.SetDiscriminator("Piercing");
            });
        }

        if (!BsonClassMap.IsClassMapRegistered(typeof(Pingente)))
        {
            BsonClassMap.RegisterClassMap<Pingente>(cm =>
            {
                cm.AutoMap();
                cm.SetDiscriminator("Pingente");
            });
        }

        if (!BsonClassMap.IsClassMapRegistered(typeof(Pulseira)))
        {
            BsonClassMap.RegisterClassMap<Pulseira>(cm =>
            {
                cm.AutoMap();
                cm.SetDiscriminator("Pulseira");
            });
        }

        if (!BsonClassMap.IsClassMapRegistered(typeof(Relogio)))
        {
            BsonClassMap.RegisterClassMap<Relogio>(cm =>
            {
                cm.AutoMap();
                cm.SetDiscriminator("Relogio");
            });
        }
    }
}
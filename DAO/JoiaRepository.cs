using DAO.Interfaces;
using Microsoft.Extensions.Configuration;
using Models.Base;
using Models.Derivatives;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DAO;

public class JoiaRepository : IJoiaRepository
{
    private readonly IMongoCollection<Joia> _joias;

    public JoiaRepository(IConfiguration config)
    {
        var client = new MongoClient(config["MongoDB:ConnectionString"]);
        var database = client.GetDatabase(config["MongoDB:DatabaseName"]);
        _joias = database.GetCollection<Joia>(config["MongoDB:CollectionName"]);

        if (!BsonClassMap.IsClassMapRegistered(typeof(Joia)))
        {
            BsonClassMap.RegisterClassMap<Joia>(cm =>
            {
                cm.AutoMap();
                cm.SetIsRootClass(true);
                cm.SetDiscriminator("Joia");
            });
        }

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

    public async Task Post(Joia joia)
    {
        await _joias.InsertOneAsync(joia);
    }

    public async Task<List<Joia>> Get()
    {
        var joias = await _joias.FindAsync(_ => true);
        return await joias.ToListAsync();
    }

    public async Task<Joia?> GetById(String id)
    {
        return await _joias.Find(j => j.Id == id).FirstOrDefaultAsync();
    }

    public async Task Put(Joia joia)
    {
        await _joias.ReplaceOneAsync(j => j.Id == joia.Id, joia);
    }

    public async Task Delete(String id)
    {
        await _joias.DeleteOneAsync(j => j.Id == id);
    }
}
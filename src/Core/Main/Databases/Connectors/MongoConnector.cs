using MongoDB.Driver;
using ApiMeli.Core.Main.Database.Protocols;

namespace ApiMeli.Core.Main.Database.Connectors
{
  public class MongoConnector: IDatabaseConnector<IMongoDatabase>
  {
    private readonly IMongoDatabase mongoDatabase;

    public MongoConnector(IDatabaseSettings settings)
    {
      mongoDatabase = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
    }

    public IMongoDatabase getDatabase(){
      return mongoDatabase;
    }
  }
}
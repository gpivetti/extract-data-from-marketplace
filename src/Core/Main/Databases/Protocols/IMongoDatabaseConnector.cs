using MongoDB.Driver;

namespace ApiMeli.Core.Main.Database.Protocols
{
  public interface IMongoDatabaseConnector
  {
    public IMongoDatabase getMongoDatabase();
  }
}
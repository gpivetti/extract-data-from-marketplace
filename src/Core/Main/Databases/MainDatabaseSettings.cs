using ApiMeli.Core.Main.Database.Protocols;

namespace ApiMeli.Core.Main.Database
{
  public class MainDatabaseSettings : IDatabaseSettings
  {
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }
}
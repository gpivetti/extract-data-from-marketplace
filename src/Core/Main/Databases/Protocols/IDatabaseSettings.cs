namespace ApiMeli.Core.Main.Database.Protocols
{
  public interface IDatabaseSettings
  {
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}
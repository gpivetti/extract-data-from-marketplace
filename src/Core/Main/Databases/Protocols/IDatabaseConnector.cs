namespace ApiMeli.Core.Main.Database.Protocols
{
  public interface IDatabaseConnector<TDatabase>
  {
    public TDatabase getDatabase();
  }
}
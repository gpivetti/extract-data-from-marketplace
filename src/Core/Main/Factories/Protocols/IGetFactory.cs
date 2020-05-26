namespace ApiMeli.Core.Factories.Protocols
{
  public interface IGetFactory<TClass>
  {
    public TClass handle();
  }
}
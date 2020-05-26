namespace ApiMeli.Core.Factories.Protocols
{
  public interface IGetInterface<TClass>
  {
    public TClass handle();
  }
}
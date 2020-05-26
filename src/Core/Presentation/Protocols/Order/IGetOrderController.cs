namespace ApiMeli.Core.Controllers.Protocols
{
  public interface IGetOrderController
  {
    public string getOrder(string source, string code, string custumerId = null);      
  }
}
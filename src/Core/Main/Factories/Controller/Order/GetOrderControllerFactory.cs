using ApiMeli.Core.Controllers;
using ApiMeli.Core.Controllers.Protocols;
using ApiMeli.Core.Factories.UseCases;
using ApiMeli.Core.Factories.Protocols;

namespace ApiMeli.Core.Factories.Controllers
{
  public class GetOrderControllerFactory : IGetFactory<IGetOrderController>
  {
    private readonly string custumerId;

    public GetOrderControllerFactory(string _custumerId) {
      custumerId = _custumerId;
    }

    public IGetOrderController handle() {      
      return new GetOrderController(new DBGetCustumerSourceFactory(custumerId).handle());
    }
  }
}
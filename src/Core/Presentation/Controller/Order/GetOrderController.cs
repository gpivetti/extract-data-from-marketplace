using ApiMeli.Core.Domain.UseCases;
using ApiMeli.Core.Controllers.Protocols;

namespace ApiMeli.Core.Controllers
{
  public class GetOrderController : IGetOrderController
  {
    private readonly IGetCustumersSources getCustumersSources;

    public GetOrderController(IGetCustumersSources _getCustumersSources){
      getCustumersSources = _getCustumersSources;
    }

    public string getOrder(string source, string code, string custumerId = null) {
      // Retorna erro se não possuir custumer
      
      // Retorna os dados do source do custumer
      getCustumersSources.getByCustumerAndSource(source, custumerId);
      
      // Busca os dados do orders

      return $"Custumer: {custumerId} - Code: {code}";
    }
      
  }
}
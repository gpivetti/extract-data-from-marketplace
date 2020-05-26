using System;
using Microsoft.AspNetCore.Mvc;
using ApiMeli.Core.Factories.Controllers;

namespace ApiMeli.Interfaces.Api
{
  [ApiController]
  [Route("orders")]
  public class GetOrderApiInterface : ControllerBase
  {
    [HttpGet("{source}/{code}", Name = "GetOrderByCode")]
    public string Get(string sourceToken, string code) {
      // Verifica se possui o id do custumer no header
      // Console.WriteLine(mongoConnector.getString());
      var custumerId = "tst001";
      var controller = new GetOrderControllerFactory(custumerId).handle();
      return controller.getOrder(sourceToken, code, custumerId);
    }
  }
}
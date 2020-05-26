using System.Collections.Generic;

namespace ApiMeli.Core.Domain.UseCases
{    
  public interface IGetOrders
  {
      public List<string> Get();
      public string Get(string id);
  }
}
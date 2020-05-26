using ApiMeli.Domain.Models;
using System.Collections.Generic;

namespace ApiMeli.RicardoEletro.Domain.UseCases
{    
  public interface IGetOrderRicardoEletroUseCase
  {
      public List<string> Get();
      public string Get(string id);
  }
}
using System;
using Newtonsoft.Json;

using ApiMeli.Core.Domain.UseCases;
using ApiMeli.Core.Domain.Models;

namespace ApiMeli.Core.Infra.MongoDB
{    
  public class CustumerSourceMongoRepository : IGetCustumerSouceRepository
  {

    private readonly string custumerId;    

    public CustumerSourceMongoRepository(string _custumerId){
      custumerId = _custumerId;
    }

    public string getSourceByToken(string sourceToken) {
      // MongoConnector mongo = new MongoConnector();
      CustumerSource custumerSource = new CustumerSource();
      return sourceToken;
    }
  }
}
using ApiMeli.Core.Data.UseCases;
using ApiMeli.Core.Domain.UseCases;
using ApiMeli.Core.Factories.Protocols;
using ApiMeli.Core.Infra.MongoDB;

namespace ApiMeli.Core.Factories.UseCases
{
  public class DBGetCustumerSourceFactory : IGetFactory<IGetCustumersSources>
  {

    private readonly string custumerId;

    public DBGetCustumerSourceFactory(string _custumerId) {
      custumerId = _custumerId;
    }

    public IGetCustumersSources handle() {
      return new DbGetCustumerSource(new CustumerSourceMongoRepository(custumerId));      
    }
  }
}
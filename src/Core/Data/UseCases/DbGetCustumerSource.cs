using ApiMeli.Core.Domain.UseCases;

namespace ApiMeli.Core.Data.UseCases
{    
  public class DbGetCustumerSource: IGetCustumersSources
  {
    private readonly IGetCustumerSouceRepository getCustumerSouceRepository;

    public DbGetCustumerSource(IGetCustumerSouceRepository _getCustumerSouceRepository) {
      getCustumerSouceRepository = _getCustumerSouceRepository;
    }

    public string getByCustumerAndSource(string sourceToken, string cutumerId) {
      getCustumerSouceRepository.getSourceByToken(sourceToken);
      return "";
    }
  }
}
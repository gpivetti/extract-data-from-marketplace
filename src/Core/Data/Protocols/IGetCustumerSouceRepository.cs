namespace ApiMeli.Core.Domain.UseCases
{    
  public interface IGetCustumerSouceRepository
  {
    public string getSourceByToken(string sourceToken);
  }
}
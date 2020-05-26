namespace ApiMeli.Core.Domain.UseCases
{    
  public interface IGetCustumersSources
  {
    public string getByCustumerAndSource(string source, string custumerId);
  }
}
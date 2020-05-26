using Microsoft.AspNetCore.Routing;

namespace ApiMeli
{
  public interface IMainRoutes
  {
    public void handle(IEndpointRouteBuilder endpoints) { }
  }
}
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace ApiMeli
{
  public interface IStartupServices
  {
    public static void startup(IServiceCollection services, IConfiguration configuration) { }
  }

  public interface IStartupApp
  {
    public static void startup(IApplicationBuilder app, IWebHostEnvironment env) { }
  }
}
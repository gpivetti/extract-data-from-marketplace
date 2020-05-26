using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using ApiMeli.Core.Main.Database;
using ApiMeli.Core.Main.Database.Connectors;
using ApiMeli.Core.Main.Database.Protocols;

namespace ApiMeli
{
  public class CoreStartupServices : IStartupServices
  {
    public static void startup(IServiceCollection services, IConfiguration configuration)
    {
      services.Configure<MainDatabaseSettings>(
        configuration.GetSection(nameof(MainDatabaseSettings)));

      services.AddSingleton<IDatabaseSettings>(sp =>
        sp.GetRequiredService<IOptions<MainDatabaseSettings>>().Value);

      services.AddSingleton<MongoConnector>();
    }
  }
}

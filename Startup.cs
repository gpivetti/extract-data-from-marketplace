using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ApiMeli
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {      
      CoreStartupServices.startup(services, Configuration);
      services.AddControllers().AddNewtonsoftJson(options => options.UseMemberCasing());
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      CoreStartupApp.startup(app, env);
    
      // Routes
      app.UseEndpoints(endpoints =>
      {
        // Routes Default
        endpoints.MapControllers();
        
        // Other Routes (Manually)
        // System.Reflection.Assembly ass = System.Reflection.Assembly.GetEntryAssembly();
        // foreach (System.Reflection.TypeInfo definedType in ass.DefinedTypes)
        // {
        //   string implementedClass = definedType.FullName;
        //   System.Collections.Generic.IEnumerable<Type> implementeds = definedType.ImplementedInterfaces;
        //   foreach (Type implemented in implementeds) {
        //     if(implemented.ToString().Contains("IMainRoutes")){
        //       Object yourInstance = ass.CreateInstance(implementedClass);
        //       System.Reflection.MethodInfo method = implemented.GetMethod("handle");
        //       method.Invoke(yourInstance, new object[] { endpoints });
        //     }
        //   } 
        // }
      });
    }
  }
}

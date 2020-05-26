// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Routing;

// namespace ApiMeli.Routes
// {
//   public class GetOrdersRoute : IMainRoutes
//   {
//     public void handle(IEndpointRouteBuilder endpoints)
//     {
//       endpoints.MapGet("/api/{code}", async context => {
//         await context.Response.WriteAsync(context.ToString());
//       });
//     }
//   }
// }
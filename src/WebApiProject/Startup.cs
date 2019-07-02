using System.Web.Http;
using Microsoft.Owin.Cors;
using Owin;

namespace WebApiProject
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();

            WebApiConfig.Register(config);
            SwaggerConfig.Register(config);

            appBuilder.UseCors(CorsOptions.AllowAll);
            appBuilder.UseWebApi(config);
        }
    }
}

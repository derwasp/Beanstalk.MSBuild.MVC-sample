using System;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    [RoutePrefix("api/healthcheck")]
    public sealed class HealthcheckController : ApiController
    {
        private static int _callCounter = 0;
     
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(new
            {
                version = AssemblyVersionInformation.AssemblyInformationalVersion,
                environment = "MY_ENVIRONMENT",
                callCount = ++_callCounter,
                hostname = System.Environment.MachineName
            });
        }
    }
}

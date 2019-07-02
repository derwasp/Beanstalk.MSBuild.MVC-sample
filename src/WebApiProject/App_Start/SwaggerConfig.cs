using System.Web.Http;
using WebActivatorEx;
using WebApiProject;
using Swashbuckle.Application;

namespace WebApiProject
{
    public sealed class SwaggerConfig
    {
        /// <summary>
        /// Register config
        /// </summary>
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Beanstalk Sample");
                    c.DescribeAllEnumsAsStrings();
                })
                .EnableSwaggerUi();
        }
    }
}

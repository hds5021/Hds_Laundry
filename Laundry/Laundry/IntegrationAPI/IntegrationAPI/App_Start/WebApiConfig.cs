using IntegrationAPI.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IntegrationAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // We Add Authorization : For Authontication of Request , LoggingFilter : For Trace the log and GlobalException Filter: For any type of exception
            config.MapHttpAttributeRoutes();
            config.Filters.Add(new AuthorizeAttribute());
            config.Filters.Add(new LoggingFilterAttribute());
            config.Filters.Add(new GlobalExceptionAttribute());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

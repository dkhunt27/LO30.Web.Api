using LO30.Web.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LO30.Web.Api
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API configuration and services

      // Web API routes
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
                name: "Games",
                routeTemplate: "api/games/{gameId}",                
                defaults: new { controller = "games", gameId = RouteParameter.Optional }
            );
      config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
    }
  }
}

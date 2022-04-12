using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TrackplanDiagonalWordTest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "WordInput", action = "WordInput" }
            );

            routes.MapRoute(
                name: "WordTable",
                url: "{controller}/{action}",
                defaults: new { controller = "WordTable", action = "WordTable" }
            );
        }
    }
}

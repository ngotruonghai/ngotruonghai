using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nganhtinhoc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*home1-index*/
            routes.MapRoute("Home1", "{type}",
            new { controller = "Home1", action = "Index" },
            new RouteValueDictionary
            {
                { "type", "nganh-tin-hoc" }
            },
            namespaces: new[] { "Nganhtinhoc.Controllers" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home1", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Nganhtinhoc.Controllers" }
            );
        }
    }
}

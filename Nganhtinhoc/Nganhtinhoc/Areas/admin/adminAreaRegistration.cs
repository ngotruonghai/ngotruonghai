using System.Web.Mvc;
using System.Web.Routing;
namespace Nganhtinhoc.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute("login1", "{type}",
          new { controller = "login1", action = "logout" },
          new RouteValueDictionary
          {
                { "type", "logout" }
          },
          namespaces: new[] { "Nganhtinhoc.Areas.admin.Controllers" });
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { Controller= "login1", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
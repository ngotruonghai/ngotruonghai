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
            /*menu-tuyển dụng*/
            routes.MapRoute("get_uuendung", "{type}",
         new { controller = "menu", action = "get_uuendung" },
         new RouteValueDictionary
         {
                { "type", "tuyen_dung" }
         },
         namespaces: new[] { "Nganhtinhoc.Controllers" });
            /*menu-thông báo ngành*/
            routes.MapRoute("menu", "{type}",
         new { controller = "menu", action = "get_thongbaonganh" },
         new RouteValueDictionary
         {
                { "type", "thong-bao-nganh" }
         },
         namespaces: new[] { "Nganhtinhoc.Controllers" });
            /*detail-chi tiết thông báo ngành*/
            routes.MapRoute("get_thongbaonganh", "{type}/{meta}",
          new { controller = "detail", action = "get_chitietthongbaonganh",meta=UrlParameter.Optional },
          new RouteValueDictionary
          {
                { "type", "thong-bao-nganh" }
          },
          namespaces: new[] { "Nganhtinhoc.Controllers" });
            /*detail-thongbaotruong-detail*/
            routes.MapRoute("get_chitietTBT", "{type}",
           new { controller = "detail", action = "get_chitietTBT" },
           new RouteValueDictionary
           {
                { "type", "thong-bao-truong" }
           },
           namespaces: new[] { "Nganhtinhoc.Controllers" });
            /*detail-thongbaotruong-meta*/
            routes.MapRoute("detail", "{type}/{meta}",
           new { controller = "detail", action = "get_thongbaotruong", meta=UrlParameter.Optional },
           new RouteValueDictionary
           {
                { "type", "thong-bao-truong" }
           },
           namespaces: new[] { "Nganhtinhoc.Controllers" });
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

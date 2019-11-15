using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Areas.admin.Controllers
{
    public class baseeController : Controller
    {
        // GET: admin/basee
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            {
                var result = (loginMD)Session[Common.User_session];
                if (result == null)
                {
                    filterContext.Result = new RedirectToRouteResult
                        (new System.Web.Routing.RouteValueDictionary(new
                        { Controller = "login1", action = "Index", Areas = "admin" }));
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
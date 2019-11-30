using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            {
                var result = (loginMD)Session[Common.User_session];
                if (result == null)
                {
                    filterContext.Result = new RedirectToRouteResult
                        (new System.Web.Routing.RouteValueDictionary(new
                        { Controller = "loginGV", action = "Index" }));
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
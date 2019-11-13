using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nganhtinhoc.Areas.admin.Controllers
{
    public class HomeController : baseeController
    {
        // GET: admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
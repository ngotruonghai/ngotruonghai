using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nganhtinhoc.Areas.admin.Models
{
    public class trangController : Controller
    {
        // GET: admin/trang
        public ActionResult Index()
        {
            return View();
        }
    }
}
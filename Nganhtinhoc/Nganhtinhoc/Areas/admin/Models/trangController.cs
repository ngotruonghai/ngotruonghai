using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Areas.admin.Controllers;
namespace Nganhtinhoc.Areas.admin.Models
{
    public class trangController : baseeController
    {
        // GET: admin/trang
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Controllers
{
    public class Home1Controller : Controller
    {
        NTHEntities db = new NTHEntities();
        // GET: Home1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult get_thongbao()
        {
            var v = (from f in db.Thongbao
                    where f.hide == true
                    orderby f.id descending
                    select f).Take(3);
            return PartialView(v.ToList());
        }
        public ActionResult get_thongbaotruong()
        {
            var v = (from f in db.Thongbaotruong
                     where f.hide == true
                     orderby f.id descending
                     select f).Take(5);
            return PartialView(v.ToList());
        }
    }
}
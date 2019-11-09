using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Controllers
{
    public class detailController : Controller
    {
        NTHEntities db = new NTHEntities();
        // GET: detail
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult get_thongbaotruong(string meta)
        {
            var v = from f in db.Thongbaotruong
                    where f.meta==meta
                    select f;
            return PartialView(v.ToList());
        }
        public ActionResult get_chitietTBT()
        {
            var v = from f in db.Thongbaotruong
                    select f;
            return PartialView(v.ToList());
        }
    }
}
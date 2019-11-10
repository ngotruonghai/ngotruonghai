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
                     select f).Take(4);
            return PartialView(v.ToList());
        }
        //public ActionResult get_tailieu(string ma)
        //{
        //    var v = (from f in db.Tailieu
        //             where f.magiaovien == ma
        //             orderby f.id descending
        //             select f);
        //    return PartialView(v.ToList());
        //}
        //public ActionResult get_giaovien()
        //{
        //    var v = from f in db.Giaovien
        //            select f;
        //    return PartialView(v.ToList());
        //}
        public ActionResult get_tailieu()
        {
            var v = (from f in db.Tailieu
                     orderby f.id descending
                     select f).Take(4);
            return PartialView(v.ToList());
        }
        public ActionResult get_giaovien(string ma)
        {
            var v = from f in db.Giaovien
                    where f.magiaovien==ma
                    select f;
            return PartialView(v.ToList());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;
using System.IO;

namespace Nganhtinhoc.Areas.admin.Controllers
{
    public class HomeController : baseeController
    {
        private NTHEntities db= new NTHEntities();
        // GET: admin/Home
        public ActionResult Index()
        {
            int tong =0;
            //DateTime dt = new DateTime.Now;
            var v = (from f in db.Thongbao
                     where f.ngay.Value.Month == System.DateTime.Now.Month
                     select f).Count();
            var tbt = (from f in db.Thongbaotruong
                      where f.ngay.Value.Month == System.DateTime.Now.Month
                      select f).Count();
            var sv = (from f in db.Sinhvien
                     select f).Count();
            tong = v + tbt;
            ViewBag.thang = tong.ToString();
            ViewBag.sv = sv.ToString();
            return View();
        }
    }
}
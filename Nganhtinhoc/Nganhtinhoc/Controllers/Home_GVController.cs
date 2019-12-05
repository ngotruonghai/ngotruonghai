using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;
using PagedList;

namespace Nganhtinhoc.Controllers
{
    public class Home_GVController : BaseController
    {
         NTHEntities db = new NTHEntities();
        // GET: Home_GV
        public ActionResult Index(string ma)
        {
            var v = from f in db.Giaovien
                    where f.magiaovien==ma
                    select f;
            return View(v.ToList());
        }
        public ActionResult get_tailieu(int ? page ,String ma)
        {
            if (page == null)
                page = 1;
            var v = (from f in db.Tailieu
                     where f.magiaovien==ma && f.hide==true
                     orderby f.id descending
                     select f);
            int pageSize = 1;
            int pageNumber = (page ?? 1);
            return PartialView(v.ToPagedList(pageNumber, pageSize));
        }
    }
}
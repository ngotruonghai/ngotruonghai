using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;

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
    }
}
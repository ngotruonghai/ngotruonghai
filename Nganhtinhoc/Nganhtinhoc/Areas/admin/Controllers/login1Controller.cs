using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model;
using Nganhtinhoc.Models;
using System.Web.Security;

namespace Nganhtinhoc.Areas.admin.Controllers
{
    public class login1Controller : Controller
    {
        // GET: admin/login1
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(loginMD model)
        {
            var result = new accout().loginn(model.user, model.pass);
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.user, model.rememberme);
                return RedirectToAction("Index", "Thongbaos1");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng!");
            }
            return View(model);
        }
    }
}
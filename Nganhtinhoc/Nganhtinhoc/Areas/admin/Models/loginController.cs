using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Areas.admin.Models
{
    public class loginController : Controller
    {
        // GET: admin/login
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
            if (result && ModelState.IsValid)
            {
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
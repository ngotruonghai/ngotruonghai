using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model;
using Nganhtinhoc.Models;
using System.Web.Security;
using model.DAO;

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
            var dao = new AccountDAO();
            var result = dao.log(model.user, model.pass);
            if (result && ModelState.IsValid)
            {
                var user = dao.GetID(model.user);
                var sesion = new loginMD();
                sesion.user = user.tk;
                Session.Add(Common.User_session, sesion);
                //FormsAuthentication.SetAuthCookie(model.user, model.rememberme);
                return RedirectToAction("Index", "Thongbao1s");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng!");
            }
            return View(model);
        }
    }
}
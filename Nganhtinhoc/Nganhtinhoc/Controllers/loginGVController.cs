using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model.DAO;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Controllers
{
    public class loginGVController : Controller
    {
        NTHEntities bd = new NTHEntities();
        // GET: loginGV
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(loginMD model)
        {
            var DAO = new AccountDAO();
            var result = DAO.LoginGV(model.user, model.pass);
            if(result && ModelState.IsValid)
            {
                var user = DAO.GetID_GV(model.user);
                var sesion = new loginMD();
                sesion.user = user.magiaovien;
                Session.Add(Common.User_session, sesion);
                return RedirectToAction("Index", "Home_GV", new {ma=model.user });
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng!");
            }
            return View(model);
        }
    }
}
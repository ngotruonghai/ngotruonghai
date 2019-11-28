using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model.DAO;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Controllers
{
    public class LoginSVController : Controller
    {
        private NTHEntities db = new NTHEntities();
        // GET: LoginSV
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult get_sinhvien(String masv)
        {
            var v = from f in db.Sinhvien
                    where f.masinhvien==masv
                    select f;
            return View(v.ToList());
        }
        public ActionResult get_thoikhoabieu(String ma)
        {
            var v = from f in db.Thoikhoabieu
                    where f.manganh==ma
                    select f;
            return View(v.ToList());
        }
        public ActionResult get_tennganh(String ma)
        {
            var v = from f in db.Nganh
                    where f.manganh == ma
                    select f;
            return PartialView(v.ToList());
        }
        [HttpPost]
        public ActionResult Index(loginMD model)
        {
            var DAO = new AccountDAO();
            var result = DAO.logSV(model.user, model.pass);
            if(result && ModelState.IsValid)
            {
                return RedirectToAction("get_sinhvien", "LoginSV",new {masv=model.user });
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng!");
            }
            return View(model);
        }
    }
}
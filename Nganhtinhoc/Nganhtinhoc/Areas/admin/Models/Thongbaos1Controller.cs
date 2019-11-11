using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;
using Nganhtinhoc.Help;
using System.Data.Entity.Validation;
using System.IO;

namespace Nganhtinhoc.Areas.admin.Models
{
    public class Thongbaos1Controller : Controller
    {
        private NTHEntities db = new NTHEntities();

        // GET: admin/Thongbaos1
        public ActionResult Index()
        {
            return View(db.Thongbao.ToList());
        }

        // GET: admin/Thongbaos1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thongbao thongbao = db.Thongbao.Find(id);
            if (thongbao == null)
            {
                return HttpNotFound();
            }
            return View(thongbao);
        }

        // GET: admin/Thongbaos1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Thongbaos1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "id,tieude,vanban,img,meta,gioithieu,ngay,hide")] Thongbao thongbao, HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    //filename = Guid.NewGuid().ToString() + img.FileName;
                    filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss-") + img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/upload/img/thongbao"), filename);
                    img.SaveAs(path);
                    thongbao.img = filename; //Lưu ý
                }
                // temp.datebegin = Convert.ToDateTime(DateTime.Now.ToShortDateString());    
                else
                {
                    thongbao.img = "";
                }
                thongbao.meta = Functions.ConvertToUnSign(thongbao.meta); //convert Tiếng Việt không dấu
                db.Thongbao.Add(thongbao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thongbao);
        }

        // GET: admin/Thongbaos1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thongbao thongbao = db.Thongbao.Find(id);
            if (thongbao == null)
            {
                return HttpNotFound();
            }
            return View(thongbao);
        }

        // POST: admin/Thongbaos1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "id,tieude,vanban,img,meta,gioithieu,ngay,hide")] Thongbao thongbao ,HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            Thongbao temp = getById(thongbao.id);
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    //filename = Guid.NewGuid().ToString() + img.FileName;
                    filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss-") + img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/upload/img/thongbao"), filename);
                    img.SaveAs(path);
                    thongbao.img = filename; //Lưu ý
                }
                // temp.datebegin = Convert.ToDateTime(DateTime.Now.ToShortDateString());                   
                temp.tieude = thongbao.tieude;
                temp.vanban = thongbao.vanban;
                temp.meta = Functions.ConvertToUnSign(thongbao.meta); //convert Tiếng Việt không dấu
                temp.hide = thongbao.hide;
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thongbao);
        }
        public Thongbao getById(long id)
        {
            return db.Thongbao.Where(x => x.id == id).FirstOrDefault();

        }
        // GET: admin/Thongbaos1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thongbao thongbao = db.Thongbao.Find(id);
            if (thongbao == null)
            {
                return HttpNotFound();
            }
            return View(thongbao);
        }

        // POST: admin/Thongbaos1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Thongbao thongbao = db.Thongbao.Find(id);
            db.Thongbao.Remove(thongbao);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

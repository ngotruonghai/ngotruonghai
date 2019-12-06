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
using System.IO;
using Nganhtinhoc.Areas.admin.Controllers;
using System.Data.Entity.Validation;

namespace Nganhtinhoc.Areas.admin.Controllers
{
    public class TuyendungsController : baseeController
    {
        private NTHEntities db = new NTHEntities();

        // GET: admin/Tuyendungs
        public ActionResult Index()
        {
            return View(db.Tuyendung.ToList());
        }

        // GET: admin/Tuyendungs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuyendung tuyendung = db.Tuyendung.Find(id);
            if (tuyendung == null)
            {
                return HttpNotFound();
            }
            return View(tuyendung);
        }

        // GET: admin/Tuyendungs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Tuyendungs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "id,img,tieude,vanban,meta,hide")] Tuyendung tuyendung, HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss-") + img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/upload/img/tuyendung"), filename);
                    img.SaveAs(path);
                    tuyendung.img = filename; //Lưu ý 
                }
                else
                {
                    tuyendung.img = "tdt.png";
                }
                tuyendung.meta = Functions.ConvertToUnSign(tuyendung.meta);
                db.Tuyendung.Add(tuyendung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tuyendung);
        }

        // GET: admin/Tuyendungs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuyendung tuyendung = db.Tuyendung.Find(id);
            if (tuyendung == null)
            {
                return HttpNotFound();
            }
            return View(tuyendung);
        }

        // POST: admin/Tuyendungs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "id,img,tieude,vanban,meta,hide")] Tuyendung tuyendung, HttpPostedFileBase img)
        {
            try
            {
                var path = "";
                var filename = "";
                Tuyendung temp = getById(tuyendung.id);         
                if (ModelState.IsValid)
                {
                    if (img != null)
                    {
                        //filename = Guid.NewGuid().ToString() + img.FileName;
                        filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss-") + img.FileName;
                        path = Path.Combine(Server.MapPath("~/Content/upload/img/tuyendung"), filename);
                        img.SaveAs(path);
                        temp.img = filename; //Lưu ý
                    }
                    temp.tieude = tuyendung.tieude;
                    //temp.description = news.description;
                    //temp.detail = news.detail;
                    temp.meta = Functions.ConvertToUnSign(tuyendung.meta); //convert Tiếng Việt không dấu
                    temp.hide = tuyendung.hide;
                    //temp.order = news.order;
                    db.Entry(temp).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(tuyendung);
        }
        public Tuyendung getById(long id)
        {
            return db.Tuyendung.Where(x => x.id == id).FirstOrDefault();

        }
        // GET: admin/Tuyendungs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuyendung tuyendung = db.Tuyendung.Find(id);
            if (tuyendung == null)
            {
                return HttpNotFound();
            }
            return View(tuyendung);
        }

        // POST: admin/Tuyendungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tuyendung tuyendung = db.Tuyendung.Find(id);
            db.Tuyendung.Remove(tuyendung);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Areas.admin.Controllers
{
    public class TuyendungsController : Controller
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
        public ActionResult Create([Bind(Include = "id,img,tieude,vanban,meta,hide")] Tuyendung tuyendung)
        {
            if (ModelState.IsValid)
            {
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
        public ActionResult Edit([Bind(Include = "id,img,tieude,vanban,meta,hide")] Tuyendung tuyendung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tuyendung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tuyendung);
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

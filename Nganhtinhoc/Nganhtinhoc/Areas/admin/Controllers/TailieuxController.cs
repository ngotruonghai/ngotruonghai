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
    public class TailieuxController : Controller
    {
        private NTHEntities db = new NTHEntities();

        // GET: admin/Tailieux
        public ActionResult Index()
        {
            var tailieu = db.Tailieu.Include(t => t.Giaovien);
            return View(tailieu.ToList());
        }

        // GET: admin/Tailieux/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tailieu tailieu = db.Tailieu.Find(id);
            if (tailieu == null)
            {
                return HttpNotFound();
            }
            return View(tailieu);
        }

        // GET: admin/Tailieux/Create
        public ActionResult Create()
        {
            ViewBag.magiaovien = new SelectList(db.Giaovien, "magiaovien", "tengiaovien");
            return View();
        }

        // POST: admin/Tailieux/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tentailieu,text,file,magiaovien")] Tailieu tailieu)
        {
            if (ModelState.IsValid)
            {
                db.Tailieu.Add(tailieu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.magiaovien = new SelectList(db.Giaovien, "magiaovien", "manganh", tailieu.magiaovien);
            return View(tailieu);
        }

        // GET: admin/Tailieux/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tailieu tailieu = db.Tailieu.Find(id);
            if (tailieu == null)
            {
                return HttpNotFound();
            }
            ViewBag.magiaovien = new SelectList(db.Giaovien, "magiaovien", "manganh", tailieu.magiaovien);
            return View(tailieu);
        }

        // POST: admin/Tailieux/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tentailieu,text,file,magiaovien")] Tailieu tailieu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tailieu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.magiaovien = new SelectList(db.Giaovien, "magiaovien", "manganh", tailieu.magiaovien);
            return View(tailieu);
        }

        // GET: admin/Tailieux/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tailieu tailieu = db.Tailieu.Find(id);
            if (tailieu == null)
            {
                return HttpNotFound();
            }
            return View(tailieu);
        }

        // POST: admin/Tailieux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tailieu tailieu = db.Tailieu.Find(id);
            db.Tailieu.Remove(tailieu);
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

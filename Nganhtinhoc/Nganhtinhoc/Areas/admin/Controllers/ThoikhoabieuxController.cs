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
    public class ThoikhoabieuxController : Controller
    {
        private NTHEntities db = new NTHEntities();

        // GET: admin/Thoikhoabieux
        public ActionResult Index()
        {
            var thoikhoabieu = db.Thoikhoabieu.Include(t => t.Nganh);
            return View(thoikhoabieu.ToList());
        }

        // GET: admin/Thoikhoabieux/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thoikhoabieu thoikhoabieu = db.Thoikhoabieu.Find(id);
            if (thoikhoabieu == null)
            {
                return HttpNotFound();
            }
            return View(thoikhoabieu);
        }

        // GET: admin/Thoikhoabieux/Create
        public ActionResult Create()
        {
            ViewBag.manganh = new SelectList(db.Nganh, "manganh", "tennganh");
            return View();
        }

        // POST: admin/Thoikhoabieux/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,manganh,monhoc,thu,phong,naybatdau,ngayketthuc,giaoviengiangday")] Thoikhoabieu thoikhoabieu)
        {
            if (ModelState.IsValid)
            {
                db.Thoikhoabieu.Add(thoikhoabieu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.manganh = new SelectList(db.Nganh, "manganh", "tennganh", thoikhoabieu.manganh);
            return View(thoikhoabieu);
        }

        // GET: admin/Thoikhoabieux/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thoikhoabieu thoikhoabieu = db.Thoikhoabieu.Find(id);
            if (thoikhoabieu == null)
            {
                return HttpNotFound();
            }
            ViewBag.manganh = new SelectList(db.Nganh, "manganh", "tennganh", thoikhoabieu.manganh);
            return View(thoikhoabieu);
        }

        // POST: admin/Thoikhoabieux/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,manganh,monhoc,thu,phong,naybatdau,ngayketthuc,giaoviengiangday")] Thoikhoabieu thoikhoabieu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thoikhoabieu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.manganh = new SelectList(db.Nganh, "manganh", "tennganh", thoikhoabieu.manganh);
            return View(thoikhoabieu);
        }

        // GET: admin/Thoikhoabieux/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thoikhoabieu thoikhoabieu = db.Thoikhoabieu.Find(id);
            if (thoikhoabieu == null)
            {
                return HttpNotFound();
            }
            return View(thoikhoabieu);
        }

        // POST: admin/Thoikhoabieux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Thoikhoabieu thoikhoabieu = db.Thoikhoabieu.Find(id);
            db.Thoikhoabieu.Remove(thoikhoabieu);
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

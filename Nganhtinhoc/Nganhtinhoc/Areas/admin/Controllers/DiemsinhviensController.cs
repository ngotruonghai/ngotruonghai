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
    public class DiemsinhviensController : baseeController
    {
        private NTHEntities db = new NTHEntities();

        // GET: admin/Diemsinhviens
        public ActionResult Index()
        {
            var diemsinhvien = db.Diemsinhvien.Include(d => d.Sinhvien);
            return View(diemsinhvien.ToList());
        }

        // GET: admin/Diemsinhviens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diemsinhvien diemsinhvien = db.Diemsinhvien.Find(id);
            if (diemsinhvien == null)
            {
                return HttpNotFound();
            }
            return View(diemsinhvien);
        }

        // GET: admin/Diemsinhviens/Create
        public ActionResult Create()
        {
            ViewBag.masinhvien = new SelectList(db.Sinhvien, "masinhvien", "manganh");
            return View();
        }

        // POST: admin/Diemsinhviens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,masinhvien,monhoc,dieml1,dieml2,dieml3,dieml4,kq")] Diemsinhvien diemsinhvien)
        {
                if (ModelState.IsValid)
                {
                    double D = double.Parse((((diemsinhvien.dieml1 + diemsinhvien.dieml2 + diemsinhvien.dieml3) * 0.3) + (diemsinhvien.dieml4 * 0.6)).ToString());
                    if (D > 5)
                    {
                        diemsinhvien.kq = "Đậu";
                    }
                    else
                    {
                        diemsinhvien.kq = "F";
                    }
                    db.Diemsinhvien.Add(diemsinhvien);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                ViewBag.masinhvien = new SelectList(db.Sinhvien, "masinhvien", "manganh", diemsinhvien.masinhvien);
                return View(diemsinhvien);
        }

        // GET: admin/Diemsinhviens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diemsinhvien diemsinhvien = db.Diemsinhvien.Find(id);
            if (diemsinhvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.masinhvien = new SelectList(db.Sinhvien, "masinhvien", "manganh", diemsinhvien.masinhvien);
            return View(diemsinhvien);
        }

        // POST: admin/Diemsinhviens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,masinhvien,monhoc,dieml1,dieml2,dieml3,dieml4,kq")] Diemsinhvien diemsinhvien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diemsinhvien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.masinhvien = new SelectList(db.Sinhvien, "masinhvien", "manganh", diemsinhvien.masinhvien);
            return View(diemsinhvien);
        }

        // GET: admin/Diemsinhviens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diemsinhvien diemsinhvien = db.Diemsinhvien.Find(id);
            if (diemsinhvien == null)
            {
                return HttpNotFound();
            }
            return View(diemsinhvien);
        }

        // POST: admin/Diemsinhviens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diemsinhvien diemsinhvien = db.Diemsinhvien.Find(id);
            db.Diemsinhvien.Remove(diemsinhvien);
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

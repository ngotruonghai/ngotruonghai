﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;
using Nganhtinhoc.Help;

namespace Nganhtinhoc.Areas.admin.Controllers
{
    public class SinhviensController : baseeController
    {
        private NTHEntities db = new NTHEntities();
        public ActionResult gat_diemsv(String ma)
        {
            var v = from f in db.Diemsinhvien
                    where f.masinhvien == ma
                    orderby f.id descending
                    select f;
            return View(v.ToList());
        }
        public ActionResult get_detaildiem(String id)
        {
            var v = (from f in db.Sinhvien
                     where f.masinhvien == id
                     select f).Include(x => x.Nganh);
            return View(v.ToList());
        }
        // GET: admin/Sinhviens
        public ActionResult Index()
        {
            var sinhvien = db.Sinhvien.Include(s => s.Nganh);
            return View(sinhvien.ToList());
        }

        // GET: admin/Sinhviens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinhvien sinhvien = db.Sinhvien.Find(id);
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            return View(sinhvien);
        }

        // GET: admin/Sinhviens/Create
        public ActionResult Create()
        {
            ViewBag.manganh = new SelectList(db.Nganh, "manganh", "tennganh");
            return View();
        }

        // POST: admin/Sinhviens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "masinhvien,manganh,tensinhvien,pass,meta")] Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                sinhvien.meta = Functions.ConvertToUnSign(sinhvien.meta);
                db.Sinhvien.Add(sinhvien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.manganh = new SelectList(db.Nganh, "manganh", "tennganh", sinhvien.manganh);
            return View(sinhvien);
        }

        // GET: admin/Sinhviens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinhvien sinhvien = db.Sinhvien.Find(id);
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.manganh = new SelectList(db.Nganh, "manganh", "tennganh", sinhvien.manganh);
            return View(sinhvien);
        }

        // POST: admin/Sinhviens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "masinhvien,manganh,tensinhvien,pass,meta")] Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinhvien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.manganh = new SelectList(db.Nganh, "manganh", "tennganh", sinhvien.manganh);
            return View(sinhvien);
        }
        // GET: admin/Sinhviens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinhvien sinhvien = db.Sinhvien.Find(id);
            //var sv = db.Sinhvien.Include(x => x.Diemsinhvien).ToList();
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            return View(sinhvien);
        }

        // POST: admin/Sinhviens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var v = db.Diemsinhvien.Where(x => x.masinhvien == id).ToList();
            db.Diemsinhvien.RemoveRange(v);
            db.SaveChanges();
            Sinhvien sinhvien = db.Sinhvien.Find(id);
            db.Sinhvien.Remove(sinhvien);
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

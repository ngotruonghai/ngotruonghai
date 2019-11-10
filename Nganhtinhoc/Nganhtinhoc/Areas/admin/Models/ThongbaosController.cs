using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;

namespace Nganhtinhoc.Areas.admin.Models
{
    public class ThongbaosController : Controller
    {
        private NTHEntities db = new NTHEntities();

        // GET: admin/Thongbaos
        public ActionResult Index()
        {
            return View(db.Thongbao.ToList());
        }

        // GET: admin/Thongbaos/Details/5
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

        // GET: admin/Thongbaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Thongbaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tieude,vanban,img,meta,gioithieu,ngay,hide")] Thongbao thongbao)
        {
            if (ModelState.IsValid)
            {
                db.Thongbao.Add(thongbao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thongbao);
        }

        // GET: admin/Thongbaos/Edit/5
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

        // POST: admin/Thongbaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tieude,vanban,img,meta,gioithieu,ngay,hide")] Thongbao thongbao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thongbao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thongbao);
        }

        // GET: admin/Thongbaos/Delete/5
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

        // POST: admin/Thongbaos/Delete/5
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;
using PagedList;

namespace Nganhtinhoc.Controllers
{
    public class detailController : Controller
    {
        NTHEntities db = new NTHEntities();
        // GET: detail
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult get_thongbaotruong(string meta)
        {
            var v = from f in db.Thongbaotruong
                    where f.meta==meta
                    select f;
            return PartialView(v.ToList());
        }
        public ActionResult get_chitietTBT(int? page)
        {
            // 1. Tham số int? dùng để thể hiện null và kiểu int
            // page có thể có giá trị là null và kiểu int.

            // 2. Nếu page = null thì đặt lại là 1.
            if (page == null) page = 1;

            // 3. Tạo truy vấn, lưu ý phải sắp xếp theo trường nào đó, ví dụ OrderBy
            // theo LinkID mới có thể phân trang.
            var links = (from l in db.Thongbaotruong
                         orderby l.id descending
                         select l);

            // 4. Tạo kích thước trang (pageSize) hay là số Link hiển thị trên 1 trang
            int pageSize = 3;

            // 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            // nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            int pageNumber = (page ?? 1);

            // 5. Trả về các Link được phân trang theo kích thước và số trang.
            return PartialView(links.ToPagedList(pageNumber, pageSize));
            //var v = from f in db.Thongbaotruong
            //        select f;
            //return PartialView(v.ToList());
        }
        public ActionResult get_chitietthongbaonganh(String meta)
        {
            var v = from f in db.Thongbao
                    where f.meta == meta
                    orderby f.id descending
                    select f;
            return PartialView(v.ToList());
        }
        public ActionResult get_tuyendung(string meta)
        {
            var v = from f in db.Tuyendung
                    where f.meta == meta
                    select f;
            return View(v.ToList());
        }
    }
}
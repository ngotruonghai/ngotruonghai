using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nganhtinhoc.Models;
using PagedList;

namespace Nganhtinhoc.Controllers
{
    public class menuController : Controller
    {
        NTHEntities db = new NTHEntities();
        // GET: menu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult get_thongbaonganh(int? page)
        {
            // 1. Tham số int? dùng để thể hiện null và kiểu int
            // page có thể có giá trị là null và kiểu int.

            // 2. Nếu page = null thì đặt lại là 1.
            if (page == null) page = 1;

            // 3. Tạo truy vấn, lưu ý phải sắp xếp theo trường nào đó, ví dụ OrderBy
            // theo LinkID mới có thể phân trang.
            var links = (from l in db.Thongbao
                         orderby l.id descending
                         where l.hide == true
                         select l);

            // 4. Tạo kích thước trang (pageSize) hay là số Link hiển thị trên 1 trang
            int pageSize = 5;

            // 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            // nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            int pageNumber = (page ?? 1);

            // 5. Trả về các Link được phân trang theo kích thước và số trang.
            return PartialView(links.ToPagedList(pageNumber, pageSize));
            //var v = from f in db.Thongbaotruong
            //        select f;
            //return PartialView(v.ToList());
        }
        public ActionResult get_uuendung(int ? page)
        {
            if (page == null)
                page = 1;
            var v = (from f in db.Tuyendung
                     where f.hide == true
                     orderby f.id descending
                     select f);
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return PartialView(v.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult get_tailieu(int? page)
        {
            if (page == null)
                page = 1;
            var v = (from f in db.Tailieu
                     where f.hide == true
                     orderby f.id descending
                     select f);
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return PartialView(v.ToPagedList(pageNumber, pageSize));
        }
    }
}
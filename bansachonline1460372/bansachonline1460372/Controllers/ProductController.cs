using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bansachonline1460372.Controllers
{
    public class ProductController : Controller
    {
        int itemPerPage = 8;

        public ActionResult Index()
        {
            return View(BUS.DanhSach.Series());
        }

        public ActionResult Author(int id, int page = 1)
        {
            return View(BUS.DanhSachCua.TacGia(id, page, itemPerPage));
        }

        public ActionResult Publisher(int id, int page = 1)
        {
            return View(BUS.DanhSachCua.NhaXuatBan(id, page, itemPerPage));
        }

        public ActionResult AvailableShippingDate(int id, int page = 1)
        {
            return View(BUS.DanhSachCua.GiaoHang(id, page, itemPerPage));
        }

        public ActionResult Genre(int id, int page = 1)
        {
            return View(BUS.DanhSachCua.TheLoai(id, page, itemPerPage));
        }

        public ActionResult Series(int id, int page = 1)
        {
            return View(BUS.DanhSachCua.Series(id, page, itemPerPage));
        }

        public ActionResult List(int page = 1)
        {
            return View(BUS.DanhSach.Sach(page, 12));
        }


        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            BUS.Them.LuotXem(id);
            return View(BUS.ChiTiet.Sach(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

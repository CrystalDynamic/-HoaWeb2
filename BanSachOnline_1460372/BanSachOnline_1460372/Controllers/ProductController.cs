using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanSachOnline_1460372.Controllers
{    
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            //var ds = BanSachOnline_1460372.Models.DanhSach.get();
            return View();
        }

        public ActionResult List(int page = 1)
        {
            return View(BanSachOnline_1460372.Models.Sach.get(page, 8));
        }

        public ActionResult Author(int id, int page = 1)
        {
            return View(BanSachOnline_1460372.Models.SachCuaTacGia.get(id, page, 8));
        }

        public ActionResult Genre(int id, int page = 1)
        {
            return View(BanSachOnline_1460372.Models.SachCuaTheLoai.get(id, page, 8));
        }

        // GET: Home/Details/5

        //public ActionResult Details(int id)
        //{
        //    return View(BanSachOnline_1460372.Models.ChiTiet.get(id));
        //}



        public ActionResult Details(int id)
        {
            var sach = BanSachOnline_1460372.Models.ChiTiet.get(id);
            var tacgia = BanSachOnline_1460372.Models.ShowModel.TacGiaCuaSach.get(sach.ID_Sach);
            var theloai = BanSachOnline_1460372.Models.ShowModel.TheLoaiCuaSach.get(sach.ID_Sach);

            return View(new BanSachOnline_1460372.Models.ShowModel.SachShowModel() { Sach = sach, TacGia = tacgia, TheLoai = theloai });
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

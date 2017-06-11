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

        // GET: Product
        public ActionResult Index()
        {
            return View(bansachonline1460372.Models.BUS.Product.QuangCao.get());
        }       

        public ActionResult Author(int id, int page = 1)
        {
            return View(bansachonline1460372.Models.BUS.Product.SachCuaTacGia.get(id, page, itemPerPage));
        }

        public ActionResult Publisher(int id, int page = 1)
        {
            return View(bansachonline1460372.Models.BUS.Product.SachCuaNhaXuatBan.get(id, page, itemPerPage));
        }

        public ActionResult Genre(int id, int page = 1)
        {
            return View(bansachonline1460372.Models.BUS.Product.SachCuaTheLoai.get(id, page, itemPerPage));
        }

        public ActionResult Series(int id, int page = 1)
        {
            return View(bansachonline1460372.Models.BUS.Product.SachCuaSeries.get(id, page, itemPerPage));
        }

        public ActionResult AvailableShippingDate(int id, int page = 1)
        {
            return View(bansachonline1460372.Models.BUS.Product.SachCuaGiaoHang.get(id, page, itemPerPage));
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var sach = bansachonline1460372.Models.BUS.Product.Detail.ChiTiet.get(id);

            var tacgia = bansachonline1460372.Models.BUS.Product.Detail.TacGiaCuaSach.get(sach.ID_Sach);
            var theloai = bansachonline1460372.Models.BUS.Product.Detail.TheLoaiCuaSach.get(sach.ID_Sach);
            var nhaxuatban = bansachonline1460372.Models.BUS.Product.Detail.NhaXuatBanCuaSach.get(sach.ID_Sach);
            var series = bansachonline1460372.Models.BUS.Product.Detail.SeriesCuaSach.get(sach.ID_Sach);
            var shipping = bansachonline1460372.Models.BUS.Product.Detail.AvailableShippingDateCuaSach.get(sach.ID_Sach);

            return View(new bansachonline1460372.Models.BUS.Product.Detail.dtoSach()
            { Sach = sach, TacGia = tacgia, TheLoai = theloai, NhaXuatBan = nhaxuatban, Series = series, AvailableShippingDate = shipping });
        }

        public ActionResult List(int page = 1)
        {
            return View(bansachonline1460372.Models.BUS.Product.DanhSach.get(page, 12));
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

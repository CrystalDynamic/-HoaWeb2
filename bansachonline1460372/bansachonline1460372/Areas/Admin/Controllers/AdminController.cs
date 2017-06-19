using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bansachonline1460372.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View(BUS.KimGoEun.dsctS());
        }

        public ActionResult TK()
        {
            return View(BUS.DanhSach.TaiKhoan());
        }

        public ActionResult Bill()
        {
            return View(BUS.DanhSach.DonHang());
        }

        public ActionResult Del(int id)
        {
            BUS.Xoa.Sach(id);
            return RedirectToAction("Index");
        }

        public ActionResult Upd(int id)
        {
            return View(BUS.ChiTiet.Sach(id));
        }

        public ActionResult Del1(string id)
        {
            BUS.Xoa.TaiKhoan(id);
            return RedirectToAction("TK");
        }

        public ActionResult Upd1(string id)
        {
            return View(BUS.ChiTiet.TaiKhoan(id));
        }

        public ActionResult Del3(int id)
        {
            BUS.Xoa.DonHang(id);
            return RedirectToAction("Bill");
        }

        public ActionResult Upd3(int id)
        {
            return View(BUS.ChiTiet.DonHang(id));
        }



        public ActionResult UpdProduct(int ID_Sach, string ten ,decimal gia)
        {
            BUS.CapNhat.Sach(ID_Sach, ten, gia);
            return RedirectToAction("Index");
        }

        public ActionResult UpdAccount(string id, string ten, string matkhau, string email)
        {
            BUS.CapNhat.TaiKhoan(id, ten, matkhau, email);
            return RedirectToAction("TK");
        }

        public ActionResult UpdBill(int id, int soluong, int tongtien)
        {
            BUS.CapNhat.DonHang(id, soluong, tongtien);
            return RedirectToAction("Bill");
        }

        // GET: Admin/Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin/Create
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

        // GET: Admin/Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Admin/Edit/5
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

        // GET: Admin/Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Admin/Delete/5
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

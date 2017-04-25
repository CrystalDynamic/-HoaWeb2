using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanSachOnline1460372.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var ds = BanSachOnline1460372.Models.DanhSach.ds();
            return View();
        }
                

        public ActionResult List(int page=1)
        {            
            return View(BanSachOnline1460372.Models.DanhSach.ds(page, 8));
        }

        public ActionResult Author(int id, int page=1)
        {
            return View(BanSachOnline1460372.Models.SachCuaTacGia.SCTG(id, page, 4));
        }

        public ActionResult Genre(int id, int page=1)
        {
            return View(BanSachOnline1460372.Models.SachCuaTheLoai.SCTL(id, page, 4));
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            //var ct = BanSachOnline1460372.Models.ChiTiet.ct(id);
            //var tg = BanSachOnline1460372.Models.ShowModel.TacGiaCuaSach.Get(ct.recID);
            //return View(new BanSachOnline1460372.Models.ShowModel.SachShowModel() { Sach = ct, TacGia = tg });
            
            return View(BanSachOnline1460372.Models.ChiTiet.ct(id));
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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

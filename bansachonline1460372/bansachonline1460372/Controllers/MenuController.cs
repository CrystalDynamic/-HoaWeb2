using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bansachonline1460372.Controllers
{
    public class MenuController : Controller
    {
        public ActionResult Author_Menu()
        {
            return View(BUS.DanhSach.TacGia());
        }

        public ActionResult Genre_Menu()
        {
            return View(BUS.DanhSach.TheLoai());
        }

        public ActionResult Publisher_Menu()
        {
            return View(BUS.DanhSach.NhaXuatBan());
        }

        public ActionResult Series_Menu()
        {
            return View(BUS.DanhSach.Series());
        }

        public ActionResult AvailableShippingDate_Menu()
        {
            return View(BUS.DanhSach.GiaoHang());
        }

        public ActionResult List_Menu()
        {
            return View();
        }

        public ActionResult Search_Menu()
        {
            return View();
        }

        public ActionResult Search(string keyword)
        {
            return View(BUS.DanhSach.TimKiemTen(keyword));
        }
    }
}
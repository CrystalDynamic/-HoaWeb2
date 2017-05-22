using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanSachOnline_1460372.Controllers
{
    public class MenuController : Controller
    {        

        public ActionResult Author_Menu()
        {
            return View(BanSachOnline_1460372.Models.TacGia.get());
        }

        public ActionResult Genre_Menu()
        {
            return View(BanSachOnline_1460372.Models.TheLoai.get());
        }

        public ActionResult Publisher_Menu()
        {
            return View(BanSachOnline_1460372.Models.NhaXuatBan.get());
        }

    }
}
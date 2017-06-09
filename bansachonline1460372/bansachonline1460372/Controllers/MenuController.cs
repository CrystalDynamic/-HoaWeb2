using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bansachonline1460372.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Author_Menu()
        {
            return View(bansachonline1460372.Models.BUS.Menu.TacGiaBus.get());
        }

        public ActionResult Genre_Menu()
        {
            return View(bansachonline1460372.Models.BUS.Menu.TheLoaiBus.get());
        }

        public ActionResult Publisher_Menu()
        {
            return View(bansachonline1460372.Models.BUS.Menu.NhaXuatBanBus.get());
        }

        public ActionResult Series_Menu()
        {
            return View(bansachonline1460372.Models.BUS.Menu.SeriesBus.get());
        }

        public ActionResult AvailableShippingDate_Menu()
        {
            return View(bansachonline1460372.Models.BUS.Menu.AvailableShippingDateBus.get());
        }

        public ActionResult List_Menu()
        {
            return View();
        }

        public ActionResult Search_Menu()
        {
            return View();
        }
    }
}
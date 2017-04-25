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
            var ds = BanSachOnline1460372.Models.DanhSach.ds();
            return View(ds);
        }
        
    }
}
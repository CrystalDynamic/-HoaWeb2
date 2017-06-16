using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bansachonline1460372.Controllers
{
    public class RelateController : Controller
    {
        // GET: Relate
        public ActionResult Index(int ID_Sach)
        {
            //ViewBag.ID_Sach = ID_Sach;
            return View(BUS.DanhSach.LienQuanSeries(ID_Sach));
        }
    }
}
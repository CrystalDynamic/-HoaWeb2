using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bansachonline1460372.Controllers
{
    public class ReviewController : Controller
    {
        [Authorize]
        public ActionResult Create(int ID_Sach = 0, string NoiDung = "")
        {
            if (ID_Sach == 0)
            {
                return Redirect("/");
            }

            //User.Identity
            BUS.Them.BinhLuan(ID_Sach, User.Identity.GetUserId(), User.Identity.Name, NoiDung);
            return RedirectToAction("Details", "Product", new { id = ID_Sach });
        }

        public ActionResult Index(int ID_Sach)
        {
            ViewBag.ID_Sach = ID_Sach;
            return View(BUS.DanhSach.BinhLuan(ID_Sach));
        }
    }
}
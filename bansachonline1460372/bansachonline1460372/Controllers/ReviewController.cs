using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;

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
            bansachonline1460372.Models.BUS.Review.BinhLuan.them(ID_Sach, User.Identity.GetUserId(), User.Identity.Name, NoiDung);
            return RedirectToAction("Details", "Product", new { id = ID_Sach });
        }

        public ActionResult Index(int ID_Sach)
        {
            ViewBag.ID_Sach = ID_Sach;
            return View(bansachonline1460372.Models.BUS.Review.BinhLuan.danhsach(ID_Sach));
        }
    }
}
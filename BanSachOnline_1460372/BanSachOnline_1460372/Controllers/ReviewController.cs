using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;

namespace BanSachOnline_1460372.Controllers
{
    
    public class ReviewController : Controller
    {
        // GET: Review
        [Authorize]        
        public ActionResult Create(int ID_Sach = 0, string NoiDung = "")
        {
            if (ID_Sach == 0)
            {
                return Redirect("/");
            }

            //User.Identity
            BanSachOnline_1460372.Models.BinhLuan.them(ID_Sach, User.Identity.GetUserId(), User.Identity.Name, NoiDung);
            return RedirectToAction("Details", "Product", new { id = ID_Sach });            
        }

        public ActionResult Index(int ID_Sach)
        {
            ViewBag.ID_Sach = ID_Sach;
            return View(BanSachOnline_1460372.Models.BinhLuan.DanhSach(ID_Sach));
        }
    }
}
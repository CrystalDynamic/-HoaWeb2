using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;

namespace BanSachOnline_1460372.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View(BanSachOnline_1460372.Models.GioHang.DanhSach(User.Identity.GetUserId()));
        }

        
        [HttpPost]
        public ActionResult Add(int ID_Sach)
        {            
            BanSachOnline_1460372.Models.GioHang.Them(ID_Sach, User.Identity.GetUserId());
            return RedirectToAction("Index");
        }
    }
}
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bansachonline1460372.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        // GET: Cart        
        public ActionResult Index()
        {            
            return View(BUS.KimGoEun.get(User.Identity.GetUserId()));
        }

        //[HttpPost]
        public ActionResult Add(int ID_Sach = 0)
        {
            if (ID_Sach == 0)
            {
                return Redirect("/");                
            }           

            BUS.Them.GioHang(ID_Sach, User.Identity.GetUserId());
            return RedirectToAction("Details", "Product", new { id = ID_Sach });
        }

        //[HttpPost]
        public ActionResult Update(int ID_Sach, int soluong)
        {
            BUS.CapNhat.GioHang(ID_Sach, soluong);
            return RedirectToAction("Index");
        }

        //public ActionResult CheckOut()
        //{
        //    var dsgh = BUS.KimGoEun.get(User.Identity.GetUserId();
        //    return View();
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;

namespace bansachonline1460372.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View(bansachonline1460372.Models.BUS.Cart.GioHang.danhsach(User.Identity.GetUserId()));
        }
        
        [HttpPost]
        public ActionResult Add(int ID_Sach)
        {
            bansachonline1460372.Models.BUS.Cart.GioHang.them(ID_Sach, User.Identity.GetUserId());            
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var sach = bansachonline1460372.Models.BUS.Product.Detail.ChiTiet.get(id);

            var taikhoan = bansachonline1460372.Models.BUS.Cart.Detail.TaiKhoanCuaGioHang.get(sach.ID_Sach);
            return View(new bansachonline1460372.Models.BUS.Cart.Detail.dtoGioHang()
            { Sach = sach, TaiKhoan = tacgia, TheLoai = theloai, NhaXuatBan = nhaxuatban, Series = series, AvailableShippingDate = shipping });           
        }
    }
}
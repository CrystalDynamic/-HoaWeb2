using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Cart.Detail
{
    public class TaiKhoanCuaGioHang
    {
        public static BanSachOnlineConnection.TaiKhoan get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TaiKhoan>("select TaiKhoan.* from TaiKhoan, GioHang where TaiKhoan.ID_TaiKhoan = GioHang.ID_TaiKhoan and GioHang.ID_Sach = @0", id).FirstOrDefault();
            }
        }
    }
}
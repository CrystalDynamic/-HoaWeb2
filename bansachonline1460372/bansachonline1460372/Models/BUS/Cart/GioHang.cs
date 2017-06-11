using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Cart
{
    public class GioHang
    {
        public static void them(int ID_Sach, string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                BanSachOnlineConnection.GioHang gh = new BanSachOnlineConnection.GioHang();
                gh.ID_Sach = ID_Sach;
                gh.ID_TaiKhoan = ID_TaiKhoan;
                gh.SoLuong_GioHang = 1;

                db.Insert(gh);
            }            
        }

        public static IEnumerable<BanSachOnlineConnection.GioHang> danhsach(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.GioHang>("select * from GioHang where ID_TaiKhoan = @0", ID_TaiKhoan);
            }
        }
    }
}
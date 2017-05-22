using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class GioHang
    {
        public static void Them(int id_Sach, string id_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                BanSachOnlineConnection.GioHang GioHang = new BanSachOnlineConnection.GioHang()
                {
                    ID_Sach = id_Sach,
                    ID_TaiKhoan = id_TaiKhoan,
                    SoLuong_GioHang = 1
                };
                db.Insert(GioHang);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.GioHang> DanhSach(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.GioHang>("select * from GioHang where ID_TaiKhoan = @0", ID_TaiKhoan);
            }
        }
    }
}
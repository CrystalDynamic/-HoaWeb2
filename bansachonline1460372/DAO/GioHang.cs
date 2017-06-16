using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GioHang
    {
        public static BanSachOnlineConnection.GioHang ChiTiet(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.GioHang>("select * from GioHang where GioHang.ID_GioHang = @0", id).FirstOrDefault();
            }
        }

        public static void Them(int ID_Sach, string ID_TaiKhoan, int SoLuong)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("insert into GioHang(ID_Sach, ID_TaiKhoan, SoLuong_GioHang) values (@0, @1, @2)", ID_Sach, ID_TaiKhoan, SoLuong);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.GioHang> CuaTaiKhoan(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.GioHang>("select GioHang.* from GioHang where GioHang.ID_TaiKhoan = @0", ID_TaiKhoan);
            }
        }

        public static void CapNhat(int ID_Sach, int soluong)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update GioHang set SoLuong_GioHang = @0 where ID_Sach = @1", soluong, ID_Sach);
            }
        }
    }
}

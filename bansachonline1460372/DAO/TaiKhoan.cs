using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoan
    {
        public static BanSachOnlineConnection.TaiKhoan CuaGioHang(int ID_GioHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TaiKhoan>("select * from TaiKhoan, GioHang where TaiKhoan.ID_TaiKhoan = GioHang.ID_TaiKhoan and BiXoa_TaiKhoan = 0").FirstOrDefault();
            }
        }

        public static BanSachOnlineConnection.TaiKhoan CuaTaiKhoan(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TaiKhoan>("select * from TaiKhoan where ID_TaiKhoan = @0 and BiXoa_TaiKhoan = 0", ID_TaiKhoan).FirstOrDefault();
            }
        }

        public static IEnumerable<BanSachOnlineConnection.TaiKhoan> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TaiKhoan>("select * from TaiKhoan where BiXoa_TaiKhoan = 0");
            }
        }

        public static void Xoa(string id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update TaiKhoan set BiXoa_TaiKhoan = 1 where ID_TaiKhoan = @0", id);
            }
        }

        public static void CapNhat(string id, string ten, string matkhau, string email)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update TaiKhoan set TenKhachHang_TaiKhoan = @0 where ID_TaiKhoan = @1", ten, id);
                db.Execute("update TaiKhoan set MatKhau_TaiKhoan = @0 where ID_TaiKhoan = @1", matkhau, id);
                db.Execute("update TaiKhoan set Email_TaiKhoan = @0 where ID_TaiKhoan = @1", email, id);
            }
        }
    }
}

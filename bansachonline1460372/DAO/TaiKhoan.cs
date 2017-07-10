using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoan
    {
        public static BanSachOnlineConnection.TaiKhoan CuaTaiKhoan(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.TaiKhoan>("select * from TaiKhoan where ID_TaiKhoan = @0 and BiXoa_TaiKhoan = 0", ID_TaiKhoan);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.TaiKhoan> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TaiKhoan>("select * from TaiKhoan where BiXoa_TaiKhoan = 0");
            }
        }

        public static BanSachOnlineConnection.TaiKhoan CuaGioHang(int ID_GioHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.TaiKhoan>("select TaiKhoan.* from TaiKhoan, GioHang where TaiKhoan.ID_TaiKhoan = GioHang.ID_TaiKhoan and GioHang.ID_GioHang = @0 and BiXoa_TaiKhoan = 0", ID_GioHang);
            }
        }
        
        public static BanSachOnlineConnection.TaiKhoan CuaDonHang(int ID_DonHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.TaiKhoan>("select TaiKhoan.* from TaiKhoan, DonHang where DonHang.ID_DonHang = @0 and DonHang.ID_TaiKhoan = TaiKhoan.ID_TaiKhoan and BiXoa_TaiKhoan = 0", ID_DonHang);
            }
        }

        public static void Xoa(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update TaiKhoan set BiXoa_TaiKhoan = 1 where ID_TaiKhoan = @0", ID_TaiKhoan);
            }
        }

        public static void CapNhat(string ID_TaiKhoan, string ten, string matkhau, string email)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update TaiKhoan set TenKhachHang_TaiKhoan = @0 where ID_TaiKhoan = @1", ten, ID_TaiKhoan);
                db.Execute("update TaiKhoan set MatKhau_TaiKhoan = @0 where ID_TaiKhoan = @1", matkhau, ID_TaiKhoan);
                db.Execute("update TaiKhoan set Email_TaiKhoan = @0 where ID_TaiKhoan = @1", email, ID_TaiKhoan);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DonHang
    {
        public static void Them(int ID_Sach, string ID_TaiKhoan, int SoLuong, decimal TongTien, string Ten_Sach, string TenKhachHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("insert into DonHang(ID_Sach, ID_TaiKhoan, SoLuong_DonHang, TongTien_DonHang, Ten_Sach, TenKhachHang_TaiKhoan) values (@0, @1, @2, @3, @4, @5)", ID_Sach, ID_TaiKhoan, SoLuong, TongTien, Ten_Sach, TenKhachHang);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.DonHang> DanhSach(decimal tong)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                GioHang.Xoa();                
                return db.Query<BanSachOnlineConnection.DonHang>("select * from DonHang where TongTien_DonHang = @0", tong);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.DonHang> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {                
                return db.Query<BanSachOnlineConnection.DonHang>("select * from DonHang where BiXoa_DonHang = 0");
            }
        }

        public static void Xoa(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update DonHang set BiXoa_DonHang = 1 where ID_DonHang = @0", id);
            }
        }
        //public static void ThemID()
        //{
        //    using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
        //    {
        //        db.Execute("update DonHang set id = id + 1 where ");
        //    }
        //}

        public static BanSachOnlineConnection.DonHang CuaDonHang(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.DonHang>("select * from DonHang where ID_DonHang = @0", id).FirstOrDefault();
            }
        }

        public static void CapNhat(int id, int soluong, int tongtien)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update DonHang set SoLuong_DonHang = @0 where ID_DonHang = @1", soluong, id);
                db.Execute("update DonHang set TongTien_DonHang = @0 where ID_DonHang = @1", tongtien, id);
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DonHang
    {
        public static void Them(string ID_TaiKhoan, decimal DonGia)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("insert into DonHang(ID_TaiKhoan, DonGia_DonHang) values (@0, @1)", ID_TaiKhoan, DonGia);
            }
        }

        public static void ThemChiTiet(int ID_DonHang, int soluong, int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("insert into DonHangChiTiet(ID_DonHang, ID_Sach, SoLuong_DonHangChiTiet) values (@0, @1, @2)", ID_DonHang, ID_Sach, soluong);
            }
        }
        
        public static IEnumerable<BanSachOnlineConnection.DonHang> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {                
                return db.Query<BanSachOnlineConnection.DonHang>("select * from DonHang where ID_TinhTrang != 3");
            }
        }

        public static void Xoa(int ID_DonHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update DonHang set BiXoa_DonHang = 1 where ID_DonHang = @0", ID_DonHang);
            }
        }
       
        public static BanSachOnlineConnection.DonHang CuaDonHang(int ID_DonHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.DonHang>("select * from DonHang where ID_DonHang = @0 and ID_TinhTrang != 3", ID_DonHang);
            }
        }

        //public static void CapNhat(int ID_DonHang, int soluong, int dongia)
        //{
        //    using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
        //    {
        //        db.Execute("update DonHang set SoLuong_DonHang = @0 where ID_DonHang = @1", soluong, ID_DonHang);
        //        db.Execute("update DonHang set TongTien_DonHang = @0 where ID_DonHang = @1", dongia, ID_DonHang);                
        //    }
        //}

        public static BanSachOnlineConnection.DonHang lastRec()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.DonHang>("select top 1 * from DonHang where ID_TinhTrang != 3 order by ID_DonHang desc");
            }
        }
    }
}

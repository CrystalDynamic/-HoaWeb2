using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Sach
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where BiXoa_Sach = 0");
            }
        }
        
        public static PetaPoco.Page<BanSachOnlineConnection.Sach> DanhSach(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(pageIndex, itemPer, "select * from Sach where BiXoa_Sach = 0");
            }
        }

        public static BanSachOnlineConnection.Sach CuaSach(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.Sach>("select * from Sach where BiXoa_Sach = 0 and ID_Sach = @0", ID_Sach);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaGiaoHang(int ID_AvailableShippingDate)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_AvailableShippingDate = @0 and BiXoa_Sach = 0", ID_AvailableShippingDate);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaGiaoHang(int ID_AvailableShippingDate, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_AvailableShippingDate = @0 and BiXoa_Sach = 0", ID_AvailableShippingDate);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaNhaXuatBan(int ID_NhaXuatBan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_NhaXuatBan = @0 and BiXoa_Sach = 0", ID_NhaXuatBan);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaNhaXuatBan(int ID_NhaXuatBan, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_NhaXuatBan = @0 and BiXoa_Sach = 0", ID_NhaXuatBan);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaSeries(int ID_Series)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_Series = @0 and BiXoa_Sach = 0", ID_Series);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaSeries(int ID_Series, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_Series = @0 and BiXoa_Sach = 0", ID_Series);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaTacGia(int ID_TacGia)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_TacGia = @0 and BiXoa_Sach = 0", ID_TacGia);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaTacGia(int ID_TacGia, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_TacGia = @0 and BiXoa_Sach = 0", ID_TacGia);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaTheLoai(int ID_TheLoai)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select Sach.* from Sach, TheLoai_Sach where (Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai_Sach.ID_TheLoai = @0 and Sach.BiXoa_Sach = 0)", ID_TheLoai);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaTheLoai(int ID_TheLoai, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select Sach.* from Sach, TheLoai_Sach where (Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai_Sach.ID_TheLoai = @0 and Sach.BiXoa_Sach = 0)", ID_TheLoai);
            }
        }

        public static BanSachOnlineConnection.Sach CuaGioHang(int ID_GioHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.Sach>("select Sach.* from Sach, GioHang where GioHang.ID_Sach = Sach.ID_Sach and GioHang.ID_GioHang = @0 and Sach.BiXoa_Sach = 0", ID_GioHang);
            }
        }

        //
        public static IEnumerable<BanSachOnlineConnection.Sach> LienQuanSeries(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where Sach.ID_Series = (select ID_Series from Sach where ID_Sach = @0) and BiXoa_Sach = 0", ID_Sach);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> TimTheoTen(string keyword)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where Sach.Ten_Sach like '%' +@0+ '%' or Sach.Gia_Sach like '%' +@0+ '%' and BiXoa_Sach = 0", keyword);
            }
        }

        public static void ThemLuotXem(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update Sach set Sach.LuotXem_Sach = Sach.LuotXem_Sach + 1 where Sach.ID_Sach = @0 and BiXoa_Sach = 0", ID_Sach);
            }
        }

        public static void Xoa(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update Sach set BiXoa_Sach = 1 where ID_Sach = @0", ID_Sach);
            }
        }

        public static void CapNhat(int ID_Sach, string ten, decimal gia)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update Sach set Ten_Sach = @0 where ID_Sach = @1", ten, ID_Sach);
                db.Execute("update Sach set Gia_Sach = @0 where ID_Sach = @1", gia, ID_Sach);              
            }
        }
    }
}

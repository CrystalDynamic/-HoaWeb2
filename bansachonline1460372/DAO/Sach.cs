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
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> DanhSach(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(pageIndex, itemPer, "select * from Sach");
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaGiaoHang(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_AvailableShippingDate = @0", id);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaGiaoHang(int id, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_AvailableShippingDate = @0", id);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaNhaXuatBan(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_NhaXuatBan = @0", id);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaNhaXuatBan(int id, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_NhaXuatBan = @0", id);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaSeries(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_Series = @0", id);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaSeries(int id, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_Series = @0", id);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaTacGia(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_TacGia = @0", id);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaTacGia(int id, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_TacGia = @0", id);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> CuaTheLoai(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select Sach.* from Sach, TheLoai_Sach where (Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai_Sach.ID_TheLoai = @0)", id);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> CuaTheLoai(int id, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select Sach.* from Sach, TheLoai_Sach where (Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai_Sach.ID_TheLoai = @0)", id);
            }
        }

        public static BanSachOnlineConnection.Sach CuaGioHang(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select Sach.* from Sach, GioHang where GioHang.ID_Sach = Sach.ID_Sach and GioHang.ID_GioHang = @0", id).FirstOrDefault();
            }
        }

        //
        public static IEnumerable<BanSachOnlineConnection.Sach> LienQuanSeries(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where Sach.ID_Series = (select ID_Series from Sach where ID_Sach = @0)", id);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> TimTheoTen(string keyword)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where Sach.Ten_Sach like '%' +@0+ '%' or Sach.Gia_Sach like '%' +@0+ '%'", keyword);
            }
        }

        public static BanSachOnlineConnection.Sach ChiTiet(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.SingleOrDefault<BanSachOnlineConnection.Sach>
                ("select Sach.*, TacGia.*, Series.* from Sach, TacGia, Series where Sach.ID_TacGia = TacGia.ID_TacGia and Sach.ID_Series = Series.ID_Series and Sach.ID_Sach = @0", id);
            }
        }

        public static void ThemLuotXem(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update Sach set Sach.LuotXem_Sach = Sach.LuotXem_Sach + 1 where Sach.ID_Sach = @0", id);
            }
        }
    }
}

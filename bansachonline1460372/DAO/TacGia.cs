using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TacGia
    {
        public static IEnumerable<BanSachOnlineConnection.TacGium> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TacGium>("select * from TacGia");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.TacGium> DanhSach(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.TacGium>(pageIndex, itemPer, "select * from TacGia");
            }
        }

        public static BanSachOnlineConnection.TacGium CuaSach(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.TacGium>("select TacGia.* from TacGia, Sach where Sach.ID_TacGia = TacGia.ID_TacGia and Sach.ID_Sach = @0", ID_Sach);
            }
        }

        //public static BanSachOnlineConnection.TacGium CuaGioHang(int ID_GioHang)
        //{
        //    using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
        //    {
        //        //return db.Query<BanSachOnlineConnection.TacGium>("select * from TacGia, GioHang where GioHang.ID_Sach and GioHang.ID_GioHang = @0", ID_GioHang).FirstOrDefault();
        //    }
        //}
    }
}

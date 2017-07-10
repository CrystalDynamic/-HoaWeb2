using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoai
    {
        public static IEnumerable<BanSachOnlineConnection.TheLoai> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TheLoai>("select * from TheLoai");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.TheLoai> DanhSach(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.TheLoai>(pageIndex, itemPer, "select * from TheLoai");
            }
        }

        public static IEnumerable<BanSachOnlineConnection.TheLoai> CuaSach(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TheLoai>("select TheLoai.* from TheLoai, Sach, TheLoai_Sach where Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai.ID_TheLoai = TheLoai_Sach.ID_TheLoai and Sach.ID_Sach = @0", ID_Sach);
            }
        }
    }
}

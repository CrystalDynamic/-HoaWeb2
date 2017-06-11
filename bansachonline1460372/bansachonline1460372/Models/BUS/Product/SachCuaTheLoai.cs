using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Product
{
    public class SachCuaTheLoai
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select Sach.* from Sach, TheLoai_Sach where (Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai_Sach.ID_TheLoai = @0)", id);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> get(int id, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select Sach.* from Sach, TheLoai_Sach where (Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai_Sach.ID_TheLoai = @0)", id);
            }
        }
    }
}
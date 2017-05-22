using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class SachCuaTheLoai
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> get(int id)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.Sach>("select Sach.* from Sach, TheLoai_Sach where Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai_Sach.ID_TheLoai = @0", id);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> get(int id, int pageNum, int itemPer)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Page<BanSachOnlineConnection.Sach>(pageNum, itemPer, "select Sach.* from Sach, TheLoai_Sach where (Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai_Sach.ID_TheLoai = @0)", id);
        }
    }
}
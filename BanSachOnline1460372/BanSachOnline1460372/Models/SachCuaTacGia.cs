using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline1460372.Models
{
    public class SachCuaTacGia
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> SCTG(int id)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_TacGia = @0", id);            
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> SCTG(int id, int pageNum, int itemPer)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Page<BanSachOnlineConnection.Sach>(pageNum, itemPer, "select * from Sach where ID_TacGia = @0", id);
        }
    }
}


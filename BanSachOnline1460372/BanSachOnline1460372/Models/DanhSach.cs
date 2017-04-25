using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline1460372.Models
{
    public class DanhSach
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> ds()
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.Sach>("select * from Sach");
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> ds(int pageNum, int itemPer)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Page<BanSachOnlineConnection.Sach>(pageNum, itemPer, "select * from Sach");
        }
    }
}
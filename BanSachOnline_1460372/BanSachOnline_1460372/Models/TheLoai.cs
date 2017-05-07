using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class TheLoai
    {
        public static IEnumerable<BanSachOnlineConnection.TheLoai> get()
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.TheLoai>("select * from TheLoai");
        }

        public static PetaPoco.Page<BanSachOnlineConnection.TheLoai> get(int pageNum, int itemPer)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Page<BanSachOnlineConnection.TheLoai>(pageNum, itemPer, "select * from TheLoai");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Menu
{
    public class TheLoaiBus
    {
        public static IEnumerable<BanSachOnlineConnection.TheLoai> get()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TheLoai>("select * from TheLoai");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.TheLoai> get(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.TheLoai>(pageIndex, itemPer, "select * from TheLoai");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class TacGia
    {
        public static IEnumerable<BanSachOnlineConnection.TacGium> get()
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.TacGium>("select * from TacGia");
        }

        public static PetaPoco.Page<BanSachOnlineConnection.TacGium> get(int pageNum, int itemPer)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Page<BanSachOnlineConnection.TacGium>(pageNum, itemPer, "select * from TacGia");
        }
    }
}
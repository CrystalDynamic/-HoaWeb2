using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class Series
    {
        public static IEnumerable<BanSachOnlineConnection.Series> get()
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.Series>("select * from Series");
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Series> get(int pageNum, int itemPer)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Page<BanSachOnlineConnection.Series>(pageNum, itemPer, "select * from Series");
        }
    }
}
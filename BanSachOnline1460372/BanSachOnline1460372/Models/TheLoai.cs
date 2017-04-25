using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline1460372.Models
{
    public class TheLoai
    {
        public static IEnumerable<BanSachOnlineConnection.TheLoai> genre()
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.TheLoai>("select * from TheLoai");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline1460372.Models
{
    public class TacGia
    {
        public static IEnumerable<BanSachOnlineConnection.TacGium> author()
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.TacGium>("select * from TacGia");
        }
    }
}
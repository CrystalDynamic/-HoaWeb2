using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline1460372.Models
{
    public class ChiTiet
    {
        public static BanSachOnlineConnection.Sach ct(int id)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.SingleOrDefault<BanSachOnlineConnection.Sach>("select * from Sach where recID = @0", id);
        }
    }
}
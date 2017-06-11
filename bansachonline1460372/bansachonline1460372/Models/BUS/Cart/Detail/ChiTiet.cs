using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Cart.Detail
{
    public class ChiTiet
    {
        public static BanSachOnlineConnection.GioHang get(int id)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.SingleOrDefault<BanSachOnlineConnection.GioHang>
                ("select * from GioHang where GioHang.ID_GioHang = @0", id);
        }
    }
}
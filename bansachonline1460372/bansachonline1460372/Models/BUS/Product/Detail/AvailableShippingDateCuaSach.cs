using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Product.Detail
{
    public class AvailableShippingDateCuaSach
    {
        public static BanSachOnlineConnection.AvailableShippingDate get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.AvailableShippingDate>("select AvailableShippingDate.* from AvailableShippingDate, Sach where Sach.ID_AvailableShippingDate = AvailableShippingDate.ID_AvailableShippingDate and Sach.ID_Sach = @0", id).FirstOrDefault();
            }
        }
    }
}
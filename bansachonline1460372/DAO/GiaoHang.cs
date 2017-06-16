using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoHang
    {
        public static IEnumerable<BanSachOnlineConnection.AvailableShippingDate> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.AvailableShippingDate>("select * from AvailableShippingDate");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.AvailableShippingDate> DanhSach(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.AvailableShippingDate>(pageIndex, itemPer, "select * from AvailableShippingDate");
            }
        }

        public static BanSachOnlineConnection.AvailableShippingDate CuaSach(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.AvailableShippingDate>("select AvailableShippingDate.* from AvailableShippingDate, Sach where Sach.ID_AvailableShippingDate = AvailableShippingDate.ID_AvailableShippingDate and Sach.ID_Sach = @0", id).FirstOrDefault();
            }
        }
    }
}

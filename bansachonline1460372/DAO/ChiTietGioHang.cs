using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietGioHang
    {
        public static BanSachOnlineConnection.GioHang get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.GioHang>("select * from GioHang where GioHang.ID_GioHang = @0", id).FirstOrDefault();
            }
        }
    }
}

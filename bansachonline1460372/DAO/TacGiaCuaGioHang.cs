using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TacGiaCuaGioHang
    {
        public static BanSachOnlineConnection.TacGium get(int ID_GioHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                //return db.Query<BanSachOnlineConnection.TacGium>("select * from TacGia, GioHang where GioHang.ID_Sach and GioHang.ID_GioHang = @0", ID_GioHang).FirstOrDefault();
            }
        }
    }
}

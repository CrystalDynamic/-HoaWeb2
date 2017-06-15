using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanCuaGioHang
    {
        public static BanSachOnlineConnection.TaiKhoan get(int ID_GioHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TaiKhoan>("select * from TaiKhoan, GioHang where TaiKhoan.ID_TaiKhoan = GioHang.ID_TaiKhoan").FirstOrDefault();
            }
        }
    }
}

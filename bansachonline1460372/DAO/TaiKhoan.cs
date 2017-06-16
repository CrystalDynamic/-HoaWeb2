using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoan
    {
        public static BanSachOnlineConnection.TaiKhoan CuaGioHang(int ID_GioHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TaiKhoan>("select * from TaiKhoan, GioHang where TaiKhoan.ID_TaiKhoan = GioHang.ID_TaiKhoan").FirstOrDefault();
            }
        }

        public static BanSachOnlineConnection.TaiKhoan CuaTaiKhoan(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TaiKhoan>("select * from TaiKhoan where ID_TaiKhoan = @0", ID_TaiKhoan).FirstOrDefault();
            }
        }
    }
}

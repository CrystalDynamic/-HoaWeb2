using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TinhTrang
    {
        public static IEnumerable<BanSachOnlineConnection.TinhTrang> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TinhTrang>("select * from TinhTrang");
            }
        }

        public static BanSachOnlineConnection.TinhTrang CuaTinhTrang(int ID_TinhTrang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.SingleOrDefault<BanSachOnlineConnection.TinhTrang>("select * from TinhTrang where ID_TinhTrang = @0", ID_TinhTrang);
            }
        }

        public static BanSachOnlineConnection.TinhTrang CuaDonHang(int ID_DonHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.SingleOrDefault<BanSachOnlineConnection.TinhTrang>("select TinhTrang.* from TinhTrang, DonHang where DonHang.ID_DonHang = @0 and DonHang.ID_TinhTrang = TinhTrang.ID_TinhTrang", ID_DonHang);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DonHangChiTiet
    {
        public static BanSachOnlineConnection.DonHangChiTiet CuaDonHang(int ID_DonHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.DonHangChiTiet>("select * from DonHangChiTiet where ID_DonHang = @0 and ID_TinhTrang != 3", ID_DonHang);
            }                
        }

        public static IEnumerable<BanSachOnlineConnection.DonHangChiTiet> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.DonHangChiTiet>("select * from DonHangChiTiet where ID_TinhTrang != 3");
            }
        }

        public static IEnumerable<BanSachOnlineConnection.DonHangChiTiet> DanhSachCuaDonHangChiTiet(int ID_DonHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.DonHangChiTiet>("select * from DonHangChiTiet where ID_TinhTrang != 3 and ID_DonHang = @0", ID_DonHang);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhSach
    {
        public static IEnumerable<BanSachOnlineConnection.TacGium> TacGia()
        {
            return DAO.TacGia.get();
        }

        public static IEnumerable<BanSachOnlineConnection.TheLoai> TheLoai()
        {
            return DAO.TheLoai.get();
        }

        public static IEnumerable<BanSachOnlineConnection.NhaXuatBan> NhaXuatBan()
        {
            return DAO.NhaXuatBan.get();
        }

        public static IEnumerable<BanSachOnlineConnection.Series> Series()
        {
            return DAO.Series.get();       
        }

        public static IEnumerable<BanSachOnlineConnection.AvailableShippingDate> AvailableShippingDate()
        {
            return DAO.AvailableShippingDate.get();
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> Sach(int page, int itemPer)
        {
            return DAO.Sach.get(page, itemPer);
        }
    }
}

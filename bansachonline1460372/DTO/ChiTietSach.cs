using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietSach
    {
        public BanSachOnlineConnection.Sach Sach { get; set; }
        public BanSachOnlineConnection.TacGium TacGia { get; set; }
        public IEnumerable<BanSachOnlineConnection.TheLoai> TheLoai { get; set; }
        public BanSachOnlineConnection.Series Series { get; set; }
        public BanSachOnlineConnection.NhaXuatBan NhaXuatBan { get; set; }
        public BanSachOnlineConnection.AvailableShippingDate AvailableShippingDate { get; set; }
    }
}

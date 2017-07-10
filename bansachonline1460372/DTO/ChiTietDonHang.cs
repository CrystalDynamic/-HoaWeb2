using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonHang
    {
        public BanSachOnlineConnection.DonHangChiTiet DonHangChiTiet { get; set; }
        public BanSachOnlineConnection.DonHang DonHang { get; set; }
        public ChiTietSach Sach { get; set; }
        public BanSachOnlineConnection.TaiKhoan TaiKhoan { get; set; }         
        public BanSachOnlineConnection.TinhTrang TinhTrang { get; set; }
    }
}

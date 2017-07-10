using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietGioHang
    {
        public BanSachOnlineConnection.GioHang GioHang { get; set; }
        public ChiTietSach Sach { get; set; }
        public BanSachOnlineConnection.TaiKhoan TaiKhoan { get; set; }
    }
}

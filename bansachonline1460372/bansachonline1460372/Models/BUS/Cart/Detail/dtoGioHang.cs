using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Cart.Detail
{
    public class dtoGioHang
    {
        public BanSachOnlineConnection.GioHang GioHang { get; set; }
        public BanSachOnlineConnection.Sach Sach { get; set; }
        public BanSachOnlineConnection.TaiKhoan TaiKhoan { get; set; }
    }
}
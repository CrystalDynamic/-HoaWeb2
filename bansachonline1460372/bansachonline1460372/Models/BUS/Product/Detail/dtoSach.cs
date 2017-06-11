using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Product.Detail
{
    public class dtoSach
    {
        public BanSachOnlineConnection.Sach Sach { get; set; }
        public BanSachOnlineConnection.TacGium TacGia { get; set; }
        public IEnumerable<BanSachOnlineConnection.TheLoai> TheLoai { get; set; }
        public BanSachOnlineConnection.Series Series { get; set; }
        public BanSachOnlineConnection.NhaXuatBan NhaXuatBan { get; set; }
        public BanSachOnlineConnection.AvailableShippingDate AvailableShippingDate { get; set; }
    }
}
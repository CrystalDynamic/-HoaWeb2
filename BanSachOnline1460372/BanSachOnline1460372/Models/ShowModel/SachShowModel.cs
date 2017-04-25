using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline1460372.Models.ShowModel
{
    public class SachShowModel
    {
        public BanSachOnlineConnection.Sach Sach { get; set; }
        public BanSachOnlineConnection.TacGium TacGia { get; set; }
        public BanSachOnlineConnection.TheLoai TheLoai { get; set; }
    }
}
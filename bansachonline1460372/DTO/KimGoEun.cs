using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KimGoEun //danh sach co chi tiet
    {
        public List<DTO.ChiTietGioHang> GioHang { get; set; }
        public List<DTO.ChiTietSach> Sach { get; set; }
        public List<DTO.ChiTietDonHang> DonHang { get; set; }
    }
}

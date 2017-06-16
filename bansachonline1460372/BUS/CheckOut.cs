using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CheckOut
    {
        public static void a(string ID_TaiKhoan)
        {
            decimal tong = 0;
            var dsctgh = KimGoEun.get(ID_TaiKhoan);

            foreach (var item in dsctgh.dsctGioHang)
            {
                tong = item.GioHang.SoLuong_GioHang.GetValueOrDefault() * item.Sach.Gia_Sach.GetValueOrDefault();

            }
        }
    }
}

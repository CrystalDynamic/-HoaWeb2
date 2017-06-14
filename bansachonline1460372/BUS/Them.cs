using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Them
    {
        public static void BinhLuan(int ID_Sach, string ID_TaiKhoan, string Ten_KhachHang, string NoiDung)
        {
            DAO.BinhLuan.add(ID_Sach, ID_TaiKhoan, Ten_KhachHang, NoiDung);
        }

        public static void LuotXem(int id)
        {
            DAO.ChiTietSach.add(id);
        }
    }
}

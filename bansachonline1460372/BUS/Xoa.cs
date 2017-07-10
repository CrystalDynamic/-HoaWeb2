using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Xoa
    {
        public static void Sach(int ID_Sach)
        {
            DAO.Sach.Xoa(ID_Sach);
        }

        public static void TaiKhoan(string ID_TaiKhoan)
        {
            DAO.TaiKhoan.Xoa(ID_TaiKhoan);
        }

        public static void DonHang(int ID_DonHang)
        {
            DAO.DonHang.Xoa(ID_DonHang);
        }
    }
}

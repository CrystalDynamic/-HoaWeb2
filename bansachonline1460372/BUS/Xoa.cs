using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Xoa
    {
        public static void Sach(int id)
        {
            DAO.Sach.Xoa(id);
        }

        public static void TaiKhoan(string id)
        {
            DAO.TaiKhoan.Xoa(id);
        }

        public static void DonHang(int id)
        {
            DAO.DonHang.Xoa(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CapNhat
    {
        public static void GioHang(int ID_Sach, int soluong)
        {
            DAO.GioHang.CapNhat(ID_Sach, soluong);
        }

        public static void Sach(int ID_Sach, string ten , decimal gia)
        {
            DAO.Sach.CapNhat(ID_Sach, ten, gia);
        }

        public static void TaiKhoan(string ID_TaiKhoan, string ten, string matkhau, string email)
        {
            DAO.TaiKhoan.CapNhat(ID_TaiKhoan, ten, matkhau, email);
        }

        //public static void DonHang(int id, int soluong, int tongtien)
        //{
        //    DAO.DonHang.CapNhat(id, soluong, tongtien);
        //}
    }
}

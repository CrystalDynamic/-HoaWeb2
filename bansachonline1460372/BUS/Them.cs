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
            DAO.BinhLuan.Them(ID_Sach, ID_TaiKhoan, Ten_KhachHang, NoiDung);
        }

        public static void LuotXem(int id)
        {
            DAO.Sach.ThemLuotXem(id);
        }

        public static void GioHang(int ID_Sach, string ID_TaiKhoan)
        {
            DAO.GioHang.Them(ID_Sach, ID_TaiKhoan, 1);
        }

        public static void DonHang(string ID_TaiKhoan)
        {
            decimal tong = 0;
            var dsctgh = KimGoEun.get(ID_TaiKhoan);

            foreach (var item in dsctgh.dsctGioHang)
            {
                tong = tong + item.GioHang.SoLuong_GioHang.GetValueOrDefault() * item.Sach.Gia_Sach.GetValueOrDefault();
                DAO.DonHang.Them(item.Sach.ID_Sach, item.TaiKhoan.ID_TaiKhoan, item.GioHang.SoLuong_GioHang.GetValueOrDefault(), tong, item.Sach.Ten_Sach, item.TaiKhoan.TenKhachHang_TaiKhoan);
            }
        }

        //public static void idDonHang()
        //{
        //    DAO.DonHang.ThemLuotXem(id);
        //}
    }
}

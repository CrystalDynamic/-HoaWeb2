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

        public static void LuotXem(int ID_Sach)
        {
            DAO.Sach.ThemLuotXem(ID_Sach);
        }

        public static void GioHang(int ID_Sach, string ID_TaiKhoan)
        {            
            DAO.GioHang.Them(ID_Sach, ID_TaiKhoan, 1);
        }

        public static void DonHang(string ID_TaiKhoan)
        {
            decimal tong = 0;
            var dsctGH = KimGoEun.dsctGioHang(ID_TaiKhoan).GioHang;
            
            foreach (var item in dsctGH)
            {
                tong = tong + item.GioHang.SoLuong_GioHang.GetValueOrDefault() * item.Sach.Sach.Gia_Sach.GetValueOrDefault();                
            }
            DAO.DonHang.Them(ID_TaiKhoan, tong);
            var ID_DonHang = DanhSach.DonHang().Last().ID_DonHang;
            foreach (var item in dsctGH)
            {
                DAO.DonHang.ThemChiTiet(ID_DonHang, item.GioHang.SoLuong_GioHang.GetValueOrDefault(), item.GioHang.ID_Sach);
            }
            DAO.GioHang.Xoa();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTiet
    {
        public static DTO.ChiTietSach Sach(int ID_Sach)
        {
            var sach = DAO.Sach.ChiTiet(ID_Sach);
            var tacgia = DAO.TacGia.CuaSach(sach.ID_Sach);
            var nxb = DAO.NhaXuatBan.CuaSach(sach.ID_Sach);
            var giaohang = DAO.GiaoHang.CuaSach(sach.ID_Sach);
            var seri = DAO.Series.CuaSach(sach.ID_Sach);
            var theloai = DAO.TheLoai.CuaSach(sach.ID_Sach);

            var chitiet = new DTO.ChiTietSach()
            { Sach = sach, TacGia = tacgia, AvailableShippingDate = giaohang, NhaXuatBan = nxb, Series = seri, TheLoai = theloai };
            return chitiet;
        }

        public static DTO.ChiTietGioHang GioHang(int ID_GioHang)
        {
            var giohang = DAO.GioHang.ChiTiet(ID_GioHang);
            var sach = DAO.Sach.ChiTiet(giohang.ID_Sach.GetValueOrDefault());
            //var tacgia = BUS.ChiTiet.Sach(sach.ID_Sach).TacGia;
            var taikhoan = DAO.TaiKhoan.CuaGioHang(ID_GioHang);            

            var chitiet = new DTO.ChiTietGioHang()
            { Sach = sach, TaiKhoan = taikhoan, GioHang = giohang };
            return chitiet;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTiet
    {
        public static DTO.ChiTietSach Sach(int id)
        {
            var sach = DAO.ChiTietSach.get(id);
            var tacgia = DAO.TacGiaCuaSach.get(sach.ID_Sach);
            var nxb = DAO.NhaXuatBanCuaSach.get(sach.ID_Sach);
            var giaohang = DAO.AvailableShippingDateCuaSach.get(sach.ID_Sach);
            var seri = DAO.SeriesCuaSach.get(sach.ID_Sach);
            var theloai = DAO.TheLoaiCuaSach.get(sach.ID_Sach);

            var chitiet = new DTO.ChiTietSach()
            { Sach = sach, TacGia = tacgia, AvailableShippingDate = giaohang, NhaXuatBan = nxb, Series = seri, TheLoai = theloai };
            return chitiet;
        }

        public static DTO.ChiTietGioHang GioHang(int ID_GioHang)
        {
            var giohang = DAO.ChiTietGioHang.get(ID_GioHang);
            var sach = DAO.ChiTietSach.get(giohang.ID_Sach.GetValueOrDefault());
            //var tacgia = BUS.ChiTiet.Sach(sach.ID_Sach).TacGia;
            var taikhoan = DAO.TaiKhoanCuaGioHang.get(ID_GioHang);
            var 

            return;
        }
    }
}

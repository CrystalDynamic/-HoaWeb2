using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhSach
    {
        //list of table 
        public static IEnumerable<BanSachOnlineConnection.TacGium> TacGia()
        {
            return DAO.TacGia.DanhSach();
        }

        public static IEnumerable<BanSachOnlineConnection.TheLoai> TheLoai()
        {
            return DAO.TheLoai.DanhSach();
        }

        public static IEnumerable<BanSachOnlineConnection.NhaXuatBan> NhaXuatBan()
        {
            return DAO.NhaXuatBan.DanhSach();
        }

        public static IEnumerable<BanSachOnlineConnection.Series> Series()
        {
            return DAO.Series.DanhSach();       
        }

        public static IEnumerable<BanSachOnlineConnection.AvailableShippingDate> GiaoHang()
        {
            return DAO.GiaoHang.DanhSach();
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> Sach(int page, int itemPer)
        {
            return DAO.Sach.DanhSach(page, itemPer);
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> Sach()
        {
            return DAO.Sach.DanhSach();
        }

        public static IEnumerable<BanSachOnlineConnection.TaiKhoan> TaiKhoan()
        {
            return DAO.TaiKhoan.DanhSach();
        }

        //load date theo para
        public static IEnumerable<BanSachOnlineConnection.BinhLuan> BinhLuan(int ID_Sach)
        {
            return DAO.BinhLuan.CuaSach(ID_Sach);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.BinhLuan> BinhLuan(int ID_Sach, int page, int itemPer)
        {
            return DAO.BinhLuan.CuaSach(ID_Sach, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> TacGia(int ID_TacGia, int page, int itemPer)
        {
            return DAO.Sach.CuaTacGia(ID_TacGia, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> GiaoHang(int ID_AvailableShippingDate, int page, int itemPer)
        {
            return DAO.Sach.CuaGiaoHang(ID_AvailableShippingDate, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> NhaXuatBan(int ID_NhaXuatBan, int page, int itemPer)
        {
            return DAO.Sach.CuaNhaXuatBan(ID_NhaXuatBan, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> TheLoai(int ID_TheLoai, int page, int itemPer)
        {
            return DAO.Sach.CuaTheLoai(ID_TheLoai, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> Series(int ID_Series, int page, int itemPer)
        {
            return DAO.Sach.CuaSeries(ID_Series, page, itemPer);
        }

        public static IEnumerable<BanSachOnlineConnection.GioHang> GioHang(string ID_TaiKhoan)
        {
            return DAO.GioHang.CuaTaiKhoan(ID_TaiKhoan);
        }  

        // --
        public static IEnumerable<BanSachOnlineConnection.Sach> LienQuanSeries(int ID_Sach)
        {
            return DAO.Sach.LienQuanSeries(ID_Sach);
        }

        public static IEnumerable<BanSachOnlineConnection.Sach> TimKiemTen(string keyword)
        {
            return DAO.Sach.TimTheoTen(keyword);
        }

        public static IEnumerable<BanSachOnlineConnection.DonHang> DonHang()
        {
            return DAO.DonHang.DanhSach();
        }

        public static BanSachOnlineConnection.TaiKhoan TaiKhoan(string ID_TaiKhoan)
        {
            return DAO.TaiKhoan.CuaTaiKhoan(ID_TaiKhoan);
        }

        public static BanSachOnlineConnection.DonHang DonHang(int ID_DonHang)
        {
            return DAO.DonHang.CuaDonHang(ID_DonHang);
        }

        public static IEnumerable<BanSachOnlineConnection.DonHangChiTiet> DonHangChiTiet()
        {
            return DAO.DonHangChiTiet.DanhSach();
        }
    }
}

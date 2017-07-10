using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KimGoEun
    {
        public static DTO.KimGoEun dsctGioHang(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {                
                var ds = DanhSach.GioHang(ID_TaiKhoan);
                var new_ds = new List<DTO.ChiTietGioHang>();
                
                foreach (var item in ds)
                {
                    var gh = new DTO.ChiTietGioHang()
                    {
                        GioHang = item,
                        Sach = ChiTiet.Sach(item.ID_Sach),                        
                        TaiKhoan = DanhSach.TaiKhoan(ID_TaiKhoan)
                    };
                    new_ds.Add(gh);
                }
                return new DTO.KimGoEun() { GioHang = new_ds };
            }
        }

        public static DTO.KimGoEun dsctSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                var ds = DanhSach.Sach();
                var new_ds = new List<DTO.ChiTietSach>();

                foreach (var item in ds)
                {
                    var s = new DTO.ChiTietSach()
                    {
                        Sach = item,
                        AvailableShippingDate = ChiTiet.Sach(item.ID_Sach).AvailableShippingDate,
                        NhaXuatBan = ChiTiet.Sach(item.ID_Sach).NhaXuatBan,
                        Series = ChiTiet.Sach(item.ID_Sach).Series,
                        TacGia = ChiTiet.Sach(item.ID_Sach).TacGia,
                        TheLoai = ChiTiet.Sach(item.ID_Sach).TheLoai
                    };
                    new_ds.Add(s);
                }
                return new DTO.KimGoEun() { Sach = new_ds };
            }
        }

        public static DTO.KimGoEun dsctDonHangChiTiet(int ID_DonHang)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                var ds = DAO.DonHangChiTiet.DanhSachCuaDonHangChiTiet(ID_DonHang);
                var new_ds = new List<DTO.ChiTietDonHang>();

                foreach (var item in ds)
                {
                    var dh = new DTO.ChiTietDonHang()
                    {
                        DonHangChiTiet = item,
                        DonHang = ChiTiet.DonHang(ID_DonHang).DonHang,
                        Sach = ChiTiet.Sach(item.ID_Sach.GetValueOrDefault()),
                        TaiKhoan = DAO.TaiKhoan.CuaDonHang(ID_DonHang),
                        TinhTrang = DAO.TinhTrang.CuaTinhTrang(item.ID_TinhTrang.GetValueOrDefault())
                    };
                    new_ds.Add(dh);
                }
                return new DTO.KimGoEun() { DonHang = new_ds };
            }
        }

        public static BanSachOnlineConnection.DonHang ID_DonHang()
        {
            return DAO.DonHang.lastRec();
        }
    }
}

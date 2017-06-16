using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KimGoEun
    {
        public static DTO.KimGoEun get(string ID_TaiKhoan)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                //var giohang = db.Query<BanSachOnlineConnection.GioHang>("select * from GioHang where ID_TaiKhoan = @0", ID_TaiKhoan);
                //var sach = db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_Sach in (select GioHang.ID_Sach from GioHang where ID_TaiKhoan = @0)", ID_TaiKhoan);
                //var tenkh = db.Query<BanSachOnlineConnection.TaiKhoan>("select TenKhachHang_TaiKhoan from TaiKhoan where ID_TaiKhoan = @0", ID_TaiKhoan).FirstOrDefault().TenKhachHang_TaiKhoan;

                var ds = DanhSach.GioHang(ID_TaiKhoan);
                var new_ds = new List<DTO.ChiTietGioHang>();
                
                foreach (var item in ds)
                {
                    var gh = new DTO.ChiTietGioHang()
                    { GioHang = item, Sach = DAO.Sach.CuaGioHang(item.ID_GioHang), SoLuong = item.SoLuong_GioHang.GetValueOrDefault(), TaiKhoan = DanhSach.TaiKhoan(ID_TaiKhoan) };
                    new_ds.Add(gh);
                }

                //return new DTO.KimGoEun() { Sach = sach, GioHang = giohang, TenKhachHang = tenkh, dsctGioHang = new_ds };
                return new DTO.KimGoEun() { dsctGioHang = new_ds };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class SachCuaAll
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> get()
        {
            var sql = PetaPoco.Sql.Builder
                .Append("select Sach.ID_Sach")
                .Append(", Sach.Ten_Sach")
                .Append(", TacGia.Ten_TacGia")
                .Append(", Series.Ten_Series")
                .Append(", Sach.NoiDung_Sach")
                .Append(", Sach.NgayXuatBan_Sach")
                .Append(", Sach.Gia_Sach")
                .Append(", Sach.TrangBia_Sach")
                .Append(", Sach.SoLuongBinhLuan_Sach")
                .Append(", Sach.SoLuongDanhGia_Sach")
                .Append(", NhaXuatBan.Ten_NhaXuatBan")
                .Append("from Sach")
                .Append("inner join TacGia on TacGia.ID_TacGia = Sach.ID_TacGia")
                .Append("inner join NhaXuatBan on NhaXuatBan.ID_NhaXuatBan = Sach.ID_NhaXuatBan")
                .Append("inner join Series on Series.ID_Series = Sach.ID_Series");

            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach, BanSachOnlineConnection.TacGium>(sql);
            }

        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> get(int pageNum, int itemPer)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Page<BanSachOnlineConnection.Sach>(pageNum, itemPer, "select Sach.ID_Sach, Sach.Ten_Sach, TacGia.Ten_TacGia, Series.Ten_Series, NhaXuatBan.Ten_NhaXuatBan, Sach.NoiDung_Sach, Sach.NgayXuatBan_Sach, Sach.Gia_Sach, Sach.TrangBia_Sach, Sach.SoLuongBinhLuan_Sach, Sach.SoLuongDanhGia_Sach from Sach inner join TacGia on TacGia.ID_TacGia = Sach.ID_TacGia inner join NhaXuatBan on NhaXuatBan.ID_NhaXuatBan = Sach.ID_NhaXuatBan inner join Series on Series.ID_Series = Sach.ID_Series");
        }
    }
}
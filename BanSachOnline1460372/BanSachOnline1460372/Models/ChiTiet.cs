using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline1460372.Models
{
    public class ChiTiet
    {
        public static BanSachOnlineConnection.Sach ct(int id)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();

            return db.SingleOrDefault<BanSachOnlineConnection.Sach>("select Sach.*, TacGia.Ten as TenTacGia, Series.Ten as TenSeries from Sach, TacGia, Series where Sach.ID_TacGia = TacGia.recID and Sach.ID_Series = Series.recID and Sach.recID = @0", id);
        }
    }
}
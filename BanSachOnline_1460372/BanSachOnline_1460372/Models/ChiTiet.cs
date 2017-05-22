using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class ChiTiet
    {
        public static BanSachOnlineConnection.Sach get(int id)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.SingleOrDefault<BanSachOnlineConnection.Sach>
                ("select Sach.*, TacGia.*, Series.* from Sach, TacGia, Series where Sach.ID_TacGia = TacGia.ID_TacGia and Sach.ID_Series = Series.ID_Series and Sach.ID_Sach = @0", id);
        }
    }
}
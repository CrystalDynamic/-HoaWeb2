using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline1460372.Models.ShowModel
{
    public class TacGiaCuaSach
    {
        public static BanSachOnlineConnection.TacGium Get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TacGium>("select TacGia.Ten from TacGia, Sach where Sach.recID = @0", id).FirstOrDefault();
            }
        }
    }
}
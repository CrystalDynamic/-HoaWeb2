using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class NhaXuatBan
    {
        public static IEnumerable<BanSachOnlineConnection.NhaXuatBan> get()
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Query<BanSachOnlineConnection.NhaXuatBan>("select * from NhaXuatBan");
        }

        public static PetaPoco.Page<BanSachOnlineConnection.NhaXuatBan> get(int pageNum, int itemPer)
        {
            var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB();
            return db.Page<BanSachOnlineConnection.NhaXuatBan>(pageNum, itemPer, "select * from NhaXuatBan");
        }
    }
}
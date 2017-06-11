using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Product
{
    public class SachCuaSeries
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_Series = @0", id);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> get(int id, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_Series = @0", id);
            }
        }
    }
}
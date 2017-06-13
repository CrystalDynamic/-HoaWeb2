using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Sach
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> get()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> get(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(pageIndex, itemPer, "select * from Sach");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Series
    {
        public static IEnumerable<BanSachOnlineConnection.Series> get()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Series>("select * from Series");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Series> get(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Series>(pageIndex, itemPer, "select * from Series");
            }
        }
    }
}

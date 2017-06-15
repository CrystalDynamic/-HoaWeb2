using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Search
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> get(string keyword)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where Sach.Ten_Sach like '%' +@0+ '%' or Sach.Gia_Sach like '%' +@0+ '%'", keyword);
            }
        }
    }
}

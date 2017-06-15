using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LienQuanSach
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where Sach.ID_Series = (select ID_Series from Sach where ID_Sach = @0)", id);
            }
        }
    }
}

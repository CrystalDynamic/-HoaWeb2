using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SeriesCuaSach
    {
        public static BanSachOnlineConnection.Series get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Series>("select Series.* from Series, Sach where Sach.ID_Series = Series.ID_Series and Sach.ID_Sach = @0", id).FirstOrDefault();
            }
        }
    }
}

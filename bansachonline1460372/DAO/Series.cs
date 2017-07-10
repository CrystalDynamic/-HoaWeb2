using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Series
    {
        public static IEnumerable<BanSachOnlineConnection.Series> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Series>("select * from Series");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Series> DanhSach(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Series>(pageIndex, itemPer, "select * from Series");
            }
        }

        public static BanSachOnlineConnection.Series CuaSach(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.FirstOrDefault<BanSachOnlineConnection.Series>("select Series.* from Series, Sach where Sach.ID_Series = Series.ID_Series and Sach.ID_Sach = @0", ID_Sach);
            }
        }
    }
}

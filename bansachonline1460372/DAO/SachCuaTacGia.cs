using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SachCuaTacGia
    {
        public static IEnumerable<BanSachOnlineConnection.Sach> get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.Sach>("select * from Sach where ID_TacGia = @0", id);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> get(int id, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.Sach>(page, itemPer, "select * from Sach where ID_TacGia = @0", id);
            }
        }
    }
}

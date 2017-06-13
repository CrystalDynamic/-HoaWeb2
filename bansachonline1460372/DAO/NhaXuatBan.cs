using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaXuatBan
    {
        public static IEnumerable<BanSachOnlineConnection.NhaXuatBan> get()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.NhaXuatBan>("select * from NhaXuatBan");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.NhaXuatBan> get(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.NhaXuatBan>(pageIndex, itemPer, "select * from NhaXuatBan");
            }
        }
    }
}

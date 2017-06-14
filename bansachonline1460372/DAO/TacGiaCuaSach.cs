using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TacGiaCuaSach
    {
        public static BanSachOnlineConnection.TacGium get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TacGium>("select TacGia.* from TacGia, Sach where Sach.ID_TacGia = TacGia.ID_TacGia and Sach.ID_Sach = @0", id).FirstOrDefault();
            }
        }
    }
}

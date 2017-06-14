using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietSach
    {
        public static BanSachOnlineConnection.Sach get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.SingleOrDefault<BanSachOnlineConnection.Sach>
                ("select Sach.*, TacGia.*, Series.* from Sach, TacGia, Series where Sach.ID_TacGia = TacGia.ID_TacGia and Sach.ID_Series = Series.ID_Series and Sach.ID_Sach = @0", id);
            }
        }

        public static void add(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                db.Execute("update Sach set Sach.LuotXem_Sach = Sach.LuotXem_Sach + 1 where Sach.ID_Sach = @0", id);
            }
        }
    }
}

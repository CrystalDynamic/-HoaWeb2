using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiCuaSach
    {
        public static IEnumerable<BanSachOnlineConnection.TheLoai> get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TheLoai>("select TheLoai.* from TheLoai, Sach, TheLoai_Sach where Sach.ID_Series = TheLoai_Sach.ID_Series and TheLoai.ID_TheLoai = TheLoai_Sach.ID_TheLoai and Sach.ID_Sach = @0", id);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaXuatBan
    {
        public static IEnumerable<BanSachOnlineConnection.NhaXuatBan> DanhSach()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.NhaXuatBan>("select * from NhaXuatBan");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.NhaXuatBan> DanhSach(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.NhaXuatBan>(pageIndex, itemPer, "select * from NhaXuatBan");
            }
        }

        public static BanSachOnlineConnection.NhaXuatBan CuaSach(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.NhaXuatBan>("select NhaXuatBan.* from NhaXuatBan, Sach where Sach.ID_NhaXuatBan = NhaXuatBan.ID_NhaXuatBan and Sach.ID_Sach = @0", id).FirstOrDefault();
            }
        }
    }
}

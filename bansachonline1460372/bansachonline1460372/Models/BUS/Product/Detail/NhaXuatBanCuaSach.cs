using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bansachonline1460372.Models.BUS.Product.Detail
{
    public class NhaXuatBanCuaSach
    {
        public static BanSachOnlineConnection.NhaXuatBan get(int id)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.NhaXuatBan>("select NhaXuatBan.* from NhaXuatBan, Sach where Sach.ID_NhaXuatBan = NhaXuatBan.ID_NhaXuatBan and Sach.ID_Sach = @0", id).FirstOrDefault();
            }
        }
    }
}
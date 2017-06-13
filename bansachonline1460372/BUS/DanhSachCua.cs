using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhSachCua
    {
        public static PetaPoco.Page<BanSachOnlineConnection.Sach> TacGia(int id, int page, int itemPer)
        {
            return DAO.SachCuaTacGia.get(id, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> GiaoHang(int id, int page, int itemPer)
        {
            return DAO.SachCuaGiaoHang.get(id, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> NhaXuatBan(int id, int page, int itemPer)
        {
            return DAO.SachCuaNhaXuatBan.get(id, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> TheLoai(int id, int page, int itemPer)
        {
            return DAO.SachCuaTheLoai.get(id, page, itemPer);
        }

        public static PetaPoco.Page<BanSachOnlineConnection.Sach> Series(int id, int page, int itemPer)
        {
            return DAO.SachCuaSeries.get(id, page, itemPer);
        }
    }
}

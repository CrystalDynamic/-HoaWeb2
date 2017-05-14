﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanSachOnline_1460372.Models
{
    public class BinhLuan
    {
        public static void them(int ID_Sach, string ID_KH, string NoiDung)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                BanSachOnlineConnection.BinhLuan bl = new BanSachOnlineConnection.BinhLuan();
                bl.ID_Sach = ID_Sach;
                //int x = Int32.Parse(ID_KH);
                bl.ID_KH = ID_KH;
                bl.NoiDung_BinhLuan = NoiDung;
                db.Execute("insert into BinhLuan(ID_Sach, ID_KH, NoiDung_BinhLuan) values (@0, @1, @2)", ID_Sach, ID_KH, NoiDung);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.BinhLuan> DanhSach(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.BinhLuan>("select * from BinhLuan where ID_Sach = @0", ID_Sach);
            }
        }
    }
}
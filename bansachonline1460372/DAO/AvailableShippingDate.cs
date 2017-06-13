﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AvailableShippingDate
    {
        public static IEnumerable<BanSachOnlineConnection.AvailableShippingDate> get()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.AvailableShippingDate>("select * from AvailableShippingDate");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.AvailableShippingDate> get(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.AvailableShippingDate>(pageIndex, itemPer, "select * from AvailableShippingDate");
            }
        }
    }
}
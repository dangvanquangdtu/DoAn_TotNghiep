using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopConnection;

namespace DoAnTotNghiep_BanDienThoai.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
    }
}
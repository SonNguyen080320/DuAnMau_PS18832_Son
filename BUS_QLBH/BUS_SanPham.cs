using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBH;
using DTO_QLBH;

namespace BUS_QLBH
{
    public class BUS_SanPham
    {
        DAL_SanPham dalSanPham = new DAL_SanPham();
        public DataTable TimkiemSanPham(string tenSP)
        {
            return dalSanPham.TimKiemSanPham(tenSP);
        }
        public DataTable DanhSachSanPham()
        {
            return dalSanPham.DanhSachSanPham();
        }
        public bool XoaSanPham(int maHang)
        {
            return dalSanPham.XoaSanPham(maHang);
        }
        public bool ThemSanPham(DTO_SanPham sp)
        {
            return dalSanPham.ThemSanPham(sp);
        }
        public bool SuaSanPham(DTO_SanPham sp)
        {
            return dalSanPham.SuaSanPham(sp);
        }
    }
}

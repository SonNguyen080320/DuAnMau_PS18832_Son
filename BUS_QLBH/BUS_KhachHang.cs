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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable DanhSachKH()
        {
            return dalKhachHang.DanhSachKH();
        }
        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.ThemKhachHang(kh);
        }
        public bool XoaKhachHang(string sdt)
        {
            return dalKhachHang.XoaKhachHang(sdt);
        }
        public bool CapNhatKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.CapNhatKhachHang(kh);
        }
        public DataTable TimKiemKhachHang(string sdt)
        {
            return dalKhachHang.TimKiemKhachHang(sdt);
        }
    }
}

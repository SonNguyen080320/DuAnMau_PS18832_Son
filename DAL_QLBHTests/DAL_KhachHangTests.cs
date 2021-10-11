using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;

namespace DAL_QLBH.Tests
{
    [TestClass()]
    public class DAL_KhachHangTests:DBConnect
    {
        [TestMethod()]
        public void TimKiemKH08002()
        {
            //DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang dal = new DAL_KhachHang();
            string sdt = "333";
            bool result = false;
            if(dal.TimKiemKhachHang(sdt).Rows.Count>0)
            {
                result = true;
            }    
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void ThemKhachHang08005()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang dal = new DAL_KhachHang();
            kh.dienThoai = "0123456";
            kh.tenKH = "nam";
            kh.diaChi = "vn";
            kh.gioiTinh = "Nam";
            kh.email = "sonpham06092015@gmail.com";
            bool result = dal.ThemKhachHang(kh);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void ThemKhachHang08006()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang dal = new DAL_KhachHang();
            kh.dienThoai = "";
            kh.tenKH = "nam";
            kh.diaChi = "vn";
            kh.gioiTinh = "Nam";
            kh.email = "sonpham06092015@gmail.com";
            bool result = dal.ThemKhachHang(kh);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void SuaKH08007()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang dal = new DAL_KhachHang();
            kh.dienThoai = "0123456";
            kh.tenKH = "nữ";
            kh.diaChi = "vn";
            kh.gioiTinh = "Nam";
            kh.email = "sonpham06092015@gmail.com";
            bool result = dal.CapNhatKhachHang(kh);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void SuaKH08008()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang dal = new DAL_KhachHang();
            kh.dienThoai = "0123456";
            kh.tenKH = "";
            kh.diaChi = "";
            kh.gioiTinh = "Nam";
            kh.email = "sonpham06092015@gmail.com";
            bool result = dal.CapNhatKhachHang(kh);
            Assert.IsFalse(result);
        }
    }
}
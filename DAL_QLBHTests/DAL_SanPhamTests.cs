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
    public class DAL_SanPhamTests:DBConnect
    {
        [TestMethod()]
        public void TimKiemSP06002()
        {
            DAL_SanPham dal = new DAL_SanPham();
            string ten = "one";
            bool result = false;
            if (dal.TimKiemSanPham(ten).Rows.Count > 0)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void ThemSP06005()
        {
            DTO_SanPham sp = new DTO_SanPham();
            DAL_SanPham dal = new DAL_SanPham();
            sp.tenHang = "a";
            sp.soLuong = 10;
            sp.donGiaNhap = 150000;
            sp.donGiaBan = 200000;
            sp.hinhAnh = "123";
            sp.ghiChu = "ngon";
            sp.emailNv = "sonpham06092015@gmail.com";
            bool result = dal.ThemSanPham(sp);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void ThemSP06006()
        {
            DTO_SanPham sp = new DTO_SanPham();
            DAL_SanPham dal = new DAL_SanPham();
            sp.tenHang = "a";
            sp.donGiaBan = 200000;
            sp.hinhAnh = "123";
            sp.ghiChu = "ngon";
            sp.emailNv = "sonpham06092015@gmail.com";
            bool result = dal.ThemSanPham(sp);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void SuaSP06007()
        {
            DTO_SanPham sp = new DTO_SanPham();
            DAL_SanPham dal = new DAL_SanPham();
            sp.tenHang = "a";
            sp.soLuong = 20;
            sp.donGiaNhap = 150000;
            sp.donGiaBan = 200000;
            sp.hinhAnh = "123";
            sp.ghiChu = "ngon";
            sp.emailNv = "sonpham06092015@gmail.com";
            bool result = dal.SuaSanPham(sp);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void SuaSP06008()
        {
            DTO_SanPham sp = new DTO_SanPham();
            DAL_SanPham dal = new DAL_SanPham();
            sp.tenHang = "a";
            sp.donGiaBan = 200000;
            sp.hinhAnh = "123";
            sp.ghiChu = "ngon";
            sp.emailNv = "sonpham06092015@gmail.com";
            bool result = dal.SuaSanPham(sp);
            Assert.IsFalse(result);
        }
    }
}
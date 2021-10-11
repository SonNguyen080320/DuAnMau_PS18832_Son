using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;
using System.Data;

namespace DAL_QLBH.Tests
{
    [TestClass()]
    public class DAL_NhanVienTests: DBConnect
    {
        [TestMethod()]
        public void NhanVienDangNhap01003()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.email = "";
            nv.matKhau = "abc123";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void NhanVienDangNhap01004()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.email = "sonnqps18832@fpt.edu.vn";
            nv.matKhau = "";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void NhanVienDangNhap02001()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.email = "sonpham06092015@gmail.com";
            nv.matKhau = "59E6367BFFD450AC919DC4B4D70B88E6";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void DoiMatKhau05001()
        {
            //DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien nv = new DAL_NhanVien();
            string email = "sonnqps18832@fpt.edu.vn";
            string matkhaucu = "abc";
            string matkhaumoi = "a";
            string xacnhan = "a";
            bool result = nv.UpdateMatKhau(email, matkhaucu, matkhaumoi, xacnhan);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void DoiMatKhau05002()
        {
            //DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien nv = new DAL_NhanVien();
            string email = "sonpham06092015@gmail.com";
            string matkhaucu = "abc";
            string matkhaumoi = "a";
            string xacnhan = "a";
            bool result = nv.UpdateMatKhau(email, matkhaucu, matkhaumoi, xacnhan);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void DoiMatKhau05003()
        {
            //DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien nv = new DAL_NhanVien();
            string email = "sonpham06092015@gmail.com";
            string matkhaucu = "";
            string matkhaumoi = "a";
            string xacnhan = "a";
            bool result = nv.UpdateMatKhau(email, matkhaucu, matkhaumoi, xacnhan);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void DoiMatKhau05004()
        {
            //DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien nv = new DAL_NhanVien();
            string email = "sonpham06092015@gmail.com";
            string matkhaucu = "59E6367BFFD450AC919DC4B4D70B88E6";
            string matkhaumoi = "";
            string xacnhan = "a";
            bool result = nv.UpdateMatKhau(email, matkhaucu, matkhaumoi, xacnhan);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void DoiMatKhau05005()
        {
            //DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien nv = new DAL_NhanVien();
            string email = "sonpham06092015@gmail.com";
            string matkhaucu = "59E6367BFFD450AC919DC4B4D70B88E6";
            string matkhaumoi = "a";
            string xacnhan = "";
            bool result = nv.UpdateMatKhau(email, matkhaucu, matkhaumoi, xacnhan);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void DoiMatKhau05006()
        {
            //DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien nv = new DAL_NhanVien();
            string email = "sonpham06092015@gmail.com";
            string matkhaucu = "59E6367BFFD450AC919DC4B4D70B88E6";
            string matkhaumoi = "a";
            string xacnhan = "b";
            bool result = nv.UpdateMatKhau(email, matkhaucu, matkhaumoi, xacnhan);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void TimKiemNhanVien07002()
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            string name = "Sơn";
            bool result=false;
            if(nv.TimKiemNhanVien(name).Rows.Count>0)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void TimKiemNhanVien07003()
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            string name = "";
            bool result = false;
            if (nv.TimKiemNhanVien(name).Rows.Count > 0)
            {
                result = true;
            }
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void ThemNhanVien07005()
        {
            DTO_NhanVien dtoNV = new DTO_NhanVien();
            DAL_NhanVien dalNV = new DAL_NhanVien();
            dtoNV.email = "abc@gmail.com";
            dtoNV.tenNV = "Hồ văn ý";
            dtoNV.diaChi = "Việt Nam";
            dtoNV.vaiTro = 1;
            dtoNV.tinhTrang = 1;
            dtoNV.gioiTinh = "Nam";
            bool result = dalNV.ThemNhanVien(dtoNV);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void ThemNhanVien07006()
        {
            DTO_NhanVien dtoNV = new DTO_NhanVien();
            DAL_NhanVien dalNV = new DAL_NhanVien();
            dtoNV.email = null;
            dtoNV.tenNV = null;
            dtoNV.diaChi = "Việt Nam";
            dtoNV.vaiTro = 1;
            dtoNV.tinhTrang = 1;
            dtoNV.gioiTinh = "Nam";
            bool result = dalNV.ThemNhanVien(dtoNV);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void SuaNhanVien07007()
        {
            DTO_NhanVien dtoNV = new DTO_NhanVien();
            DAL_NhanVien dalNV = new DAL_NhanVien();
            dtoNV.email = "sonpham06092015@gmail.com";
            dtoNV.tenNV = "Nguyễn Quang Sơn";
            dtoNV.diaChi = "Việt Nam";
            dtoNV.vaiTro = 1;
            dtoNV.tinhTrang = 1;
            dtoNV.gioiTinh = "Nam";
            bool result = dalNV.SuaNhanVien(dtoNV);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void SuaNhanVien07008()
        {
            DTO_NhanVien dtoNV = new DTO_NhanVien();
            DAL_NhanVien dalNV = new DAL_NhanVien();
            dtoNV.email = "sonpham06092015@gmail.com";
            dtoNV.tenNV = null;
            dtoNV.diaChi = null;
            dtoNV.vaiTro = 1;
            dtoNV.tinhTrang = 1;
            dtoNV.gioiTinh = "Nam";
            bool result = dalNV.SuaNhanVien(dtoNV);
            Assert.IsFalse(result);
        }
    }
}
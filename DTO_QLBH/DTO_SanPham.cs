using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    class DTO_SanPham
    {
        private string TenHang;
        private int SoLuong;
        private float DonGiaNhap;
        private float DonGiaBan;
        private string HinhAnh;
        private string GhiChu;
        private string EmailNV;

        public DTO_SanPham(string tenHang, int soLuong, float donGiaNhap, float donGiaBan, string hinhAnh, string ghiChu, string emailNV)
        {
            this.TenHang = tenHang;
            this.SoLuong = soLuong;
            this.DonGiaNhap = donGiaNhap;
            this.DonGiaBan = donGiaBan;
            this.HinhAnh = hinhAnh;
            this.GhiChu = ghiChu;
            this.EmailNV = emailNV;
        }
        public DTO_SanPham()
        {

        }

        public string tenHang
        {
            get { return TenHang; }
            set { TenHang = value; }
        }
        public int soLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
        public float donGiaNhap
        {
            get { return DonGiaNhap; }
            set { DonGiaNhap = value; }
        }
        public float donGiaBan
        {
            get { return DonGiaBan; }
            set { DonGiaBan = value; }
        }
        public string hinhAnh
        {
            get { return HinhAnh; }
            set { HinhAnh = value; }
        }
        public string ghiChu
        {
            get { return GhiChu; }
            set { GhiChu = value; }
        }
        public string emailNv
        {
            get { return EmailNV; }
            set { EmailNV = value; }
        }
    }
}

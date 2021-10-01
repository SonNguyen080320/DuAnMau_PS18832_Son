using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_NhanVien
    {
        private string Email;
        private string TenNV;
        private string DiaChi;
        private int VaiTro;
        private string GioiTinh;
        private int TinhTrang;
        private string MatKhau;

        public DTO_NhanVien(string email, string tenNV, string diaChi, int vaiTro, string gioiTinh, int tinhTrang, string matKhau)
        {
            this.Email = email;
            this.TenNV = tenNV;
            this.DiaChi = diaChi;
            this.VaiTro = vaiTro;
            this.GioiTinh = gioiTinh;
            this.TinhTrang = tinhTrang;
            this.MatKhau = matKhau;
        }
        public DTO_NhanVien(string email, string tenNV, string diaChi, int vaiTro, string gioiTinh, int tinhTrang)
        {
            this.Email = email;
            this.TenNV = tenNV;
            this.DiaChi = diaChi;
            this.VaiTro = vaiTro;
            this.GioiTinh = gioiTinh;
            this.TinhTrang = tinhTrang;
        }
        public DTO_NhanVien()
        {

        }

        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public string tenNV
        {
            get
            {
                return TenNV;
            }
            set
            {
                TenNV = value;
            }
        }
        public string diaChi
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }
        public int vaiTro
        {
            get
            {
                return VaiTro;
            }
            set
            {
                VaiTro = value;
            }
        }
        public string gioiTinh
        {
            get
            {
                return GioiTinh;
            }
            set
            {
                GioiTinh = value;
            }
        }
        public int tinhTrang
        {
            get
            {
                return TinhTrang;
            }
            set
            {
                TinhTrang = value;
            }
        }
        public string matKhau
        {
            get
            {
                return MatKhau;
            }
            set
            {
                MatKhau = value;
            }
        }


    }
}


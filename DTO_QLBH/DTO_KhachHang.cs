using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_KhachHang
    {
        private string DienThoai;
        private string TenKH;
        private string DiaChi;
        private string GioiTinh;
        private string EmailNV;

        public DTO_KhachHang(string dienThoai, string tenKH, string diaChi, string gioiTinh, string emailNV)
        {
            this.DienThoai = dienThoai;
            this.TenKH = tenKH;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
            this.EmailNV = emailNV;
        }
        public DTO_KhachHang()
        {

        }

        public string dienThoai
        {
            get { return DienThoai; }
            set { DienThoai = value; }
        }
        public string tenKH
        {
            get { return TenKH; }
            set { TenKH = value; }
        }
        public string diaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public string gioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        public string email
        {
            get { return EmailNV; }
            set { EmailNV = value; }
        }
    }
}

using DAL_QLBH;
using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLBH
{

    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public string encrytion(string password) // mã hóa md5
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encrypdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encrypdata.Append(encrypt[i].ToString("X2"));

            }
            return encrypdata.ToString();
        }
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalNhanVien.NhanVienDangNhap(nv);
        }
        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanVien.KiemTraEmail(email);
        }
        public bool TaoMatKhau(string email, string matkhaumoi)
        {
            return dalNhanVien.TaoMatKhau(email, matkhaumoi);
        }
        public DataTable VaiTroNhanVien(string email)
        {
            return dalNhanVien.VaiTroNhanVien(email);
        }
        public bool UpdateMatKhau(string email, string MatKhauCu, string MatKhauMoi, string XacNhanMatKhau)
        {
            return dalNhanVien.UpdateMatKhau(email, MatKhauCu, MatKhauMoi, XacNhanMatKhau);
        }
        public void sendEmail(string email, string matkhau) // gửi email
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("sonnqps18832@fpt.edu.vn", "son080320");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("sonnqps18832@fpt.edu.vn");
                Msg.To.Add(email);
                Msg.Subject = "Cập nhật mật khẩu";
                Msg.Body = "Chào anh/chị. Mật khẩu mới để truy cập phần mềm là :" + matkhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("Một Email phục hồi mật khẩu đã được gởi tới bạn!");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        public DataTable DanhSachNhanVien()
        {
            return dalNhanVien.DanhSachNhanVien();
        }
        public DataTable TimKiemNhanVien(string tenNV)
        {
            return dalNhanVien.TimKiemNhanVien(tenNV);
        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.ThemNhanVien(nv);
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool XoaNhanVien(string email)
        {
            return dalNhanVien.XoaNhanVien(email);
        }
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.SuaNhanVien(nv);
        }
    }
}

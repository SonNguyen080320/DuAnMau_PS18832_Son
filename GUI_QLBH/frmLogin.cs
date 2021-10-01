using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;
using DTO_QLBH;

namespace GUI_QLBH
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNhanVien = new BUS_QLBH.BUS_NhanVien();
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        public string RanDomString(int size, bool lowerCase) // tạo random chuỗi
        {
            StringBuilder builder = new StringBuilder();
            Random rd = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rd.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public int RanDomNumber(int min, int max) // tạo random số
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }

        private void lbquenmatkhau_Click(object sender, EventArgs e)
        {
            if (txtemaildangnhap.Text != "")
            {
                if (busNhanVien.NhanVienQuenMatKhau(txtemaildangnhap.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RanDomString(4, true));
                    builder.Append(RanDomNumber(1000, 9999));
                    builder.Append(RanDomString(2, false));
                    MessageBox.Show(builder.ToString());
                    string matkhaumoi = busNhanVien.encrytion(builder.ToString());
                    busNhanVien.TaoMatKhau(txtemaildangnhap.Text, matkhaumoi);
                    busNhanVien.sendEmail(txtemaildangnhap.Text, builder.ToString());
                }
                else
                {
                    MessageBox.Show("Email không tồn tại. vui lòng nhập lại email");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email nhận thông tin mật khẩu");
                txtemaildangnhap.Focus();
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.email = txtemaildangnhap.Text;
            nv.matKhau = busNhanVien.encrytion(txtmatkhau.Text);
            if (busNhanVien.NhanVienDangNhap(nv))
            {
                frmMain.mail = nv.email;
                if (busNhanVien.KiemTraMatKhau(txtemaildangnhap.Text))
                {
                    DataTable dt = busNhanVien.VaiTroNhanVien(nv.email);
                    if (bool.Parse(dt.Rows[0][0].ToString()) == true)
                    {
                        frmMain.vaitro = 1;
                    }
                    else { frmMain.vaitro = 0; }
                    MessageBox.Show("Đăng Nhập Thành Công");
                    frmMain.session = 1;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chào mừng bạn đến với phần mềm quản lý bán hàng. Bạn cần đổi mật khẩu trước khi sử dụng");
                    this.Close();
                    frmDoiMatKhau f1 = new frmDoiMatKhau(frmMain.mail);
                    f1.Show();
                }

            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công ! vui lòng kiểm tra lại email hoặc mật khẩu");
                txtemaildangnhap.Focus();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;
using DTO_QLBH;

namespace GUI_QLBH
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private string email;
        public frmDoiMatKhau(string _email) : this()
        {
            email = _email;

        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            txtEmail.Text = email;
            this.txtPassCu.PasswordChar = '*';
            this.txtPassMoi.PasswordChar = '*';
            this.txtXacNhanPass.PasswordChar = '*';
            btnHide.Hide();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtPassCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu củ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassCu.Focus();
            }
            else if (txtPassMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassMoi.Focus();
            }
            else if (txtXacNhanPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu xác nhận !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtXacNhanPass.Focus();
            }
            else if (txtXacNhanPass.Text.Trim().Length != txtPassMoi.Text.Trim().Length)
            {
                MessageBox.Show("xác nhận mật khẩu không chính xác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtXacNhanPass.Focus();
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn đổi mật khẩu !!!", "xác nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    string matKhauCu = busNhanVien.encrytion(txtPassCu.Text);
                    string matKhauMoi = busNhanVien.encrytion(txtPassMoi.Text);
                    string xacNhanMatKhau = busNhanVien.encrytion(txtXacNhanPass.Text);
                    if(busNhanVien.matKhau(txtEmail.Text)!=matKhauCu)
                    {
                        MessageBox.Show("Mật khẩu củ không chính xác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassCu.Focus();
                    }
                    else
                    {
                        if (busNhanVien.UpdateMatKhau(txtEmail.Text, matKhauCu, matKhauMoi, xacNhanMatKhau))
                        {
                            frmMain.profile = 1;
                            frmMain.session = 0;
                            busNhanVien.sendEmail(txtEmail.Text, matKhauMoi);
                            MessageBox.Show("Cập nhật mật khẩu thành công!!! Mời bạn đăng nhập lại hệ thống");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chức năng đổi mật khẩu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.txtPassCu.PasswordChar = '*';
            this.txtPassMoi.PasswordChar = '*';
            this.txtXacNhanPass.PasswordChar = '*';
            btnHide.Hide();
            btnUnHide.Show();
        }

        private void btnUnHide_Click(object sender, EventArgs e)
        {
            this.txtPassCu.PasswordChar = '\0';
            this.txtPassMoi.PasswordChar = '\0';
            this.txtXacNhanPass.PasswordChar = '\0';
            btnHide.Show();
            btnUnHide.Hide();
        }
    }
}

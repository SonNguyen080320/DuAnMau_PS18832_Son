using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static int session = 0;// kiểm tra tình trạng login
        public static int vaitro = 0;//kiểm tra vai trò
        public static int profile = 0;// kiểm tra đổi mật khảu thành công hay thất bại
        public static string mail;//truyền email 
        public static string MatKhau;
        public Form dn = new Form();
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            resetValue();
            if (profile == 1)
            {
                label2.Text = null;
                profile = 0;
            }
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new frmLogin();
            if (!CheckExistForm("frmLogin"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
            }
            else
            {
                ActiveChildForm("formLogin");
            }
        }
        void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();//form con đóng sẽ thực hiện code 
            frmMain_Load(sender, e);//load lại form main
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void resetValue()
        {
            if (session == 1)
            {
                label2.Text = frmMain.mail;
                hồSơNhânViênToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                danhMụcToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                if (vaitro == 0)
                {
                    VaiTroNV();
                }
            }
            else
            {
                label2.Text = "Email";
                hồSơNhânViênToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
            }
        }
        void VaiTroNV()
        {
            nhânViênToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }
        void frmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            frmMain_Load(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát phàn mềm", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!CheckExistForm("frmDoiMatKhau"))
            {
                frmDoiMatKhau frm = new frmDoiMatKhau(mail);
                frm.MdiParent = this;
                frm.FormClosed += new FormClosedEventHandler(frmDoiMatKhau_FormClosed);
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmDoiMatKhau");
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanLySanPham();
            if (!CheckExistForm("frmQuanLySanPham"))
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmQuanLySanPham");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanLyNhanVien();
            if (!CheckExistForm("frmQuanLyNhanVien"))
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmQuanLyNhanVien");
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanLyKhachHang();
            if (!CheckExistForm("frmQuanLyKhachHang"))
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmQuanLyKhachHang");
            }
        }

        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThongKeSP();
            if (!CheckExistForm("frmThongKeSP"))
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmThongKeSP");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất tài khoản ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //label2.Text = "Email";
                //hồSơNhânViênToolStripMenuItem.Visible = false;
                //đăngXuấtToolStripMenuItem.Visible = false;
                //thốngKêToolStripMenuItem.Visible = false;
                //danhMụcToolStripMenuItem.Visible = false;
                //đăngNhậpToolStripMenuItem.Enabled = true;
                Application.Restart();
            }
        }
    }
}

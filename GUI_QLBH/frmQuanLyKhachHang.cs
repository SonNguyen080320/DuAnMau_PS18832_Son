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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            resetValue();
            LoadGridView_KhachHang();
        }
        private void LoadGridView_KhachHang()
        {
            DataTable dt = busKhachHang.DanhSachKH();
            dtgvKH.DataSource = dt;
            dtgvKH.Columns[0].HeaderText = "Điện thoại";
            dtgvKH.Columns[1].HeaderText = "Tên khách hàng";
            dtgvKH.Columns[2].HeaderText = "Địa chỉ";
            dtgvKH.Columns[3].HeaderText = "Giới tính";
            dtgvKH.Columns[4].HeaderText = "Mã nhân viên";
        }
        void resetValue()
        {
            txtDiaChi.Text = null;
            txtHoTen.Text = null;
            txtSdt.Text = null;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            rdoNu.Enabled = false;
            rdoNam.Enabled = false;
            txtSdt.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            btnThem.Enabled = true;
            txtSdtTimKiem.Text = "--Nhập số điện thoại cần tim--";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = busKhachHang.TimKiemKhachHang(txtSdtTimKiem.Text);
            if (txtSdtTimKiem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    dtgvKH.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Số điện thoại không tồn tại! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSdtTimKiem.Text = "--Nhập Số điện thoại--";

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = null;
            txtHoTen.Text = null;
            txtSdt.Text = null;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            rdoNu.Enabled = true;
            rdoNam.Enabled = true;
            txtSdt.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnThem.Enabled = false;
            txtSdtTimKiem.Text = "--Nhập số điện thoại cần tim--";
            txtSdt.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busKhachHang.XoaKhachHang(txtSdt.Text))
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    resetValue();
                    LoadGridView_KhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Nữ";
            if (rdoNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính khách hàng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txtSdt.Text, txtHoTen.Text, txtDiaChi.Text, gioiTinh, frmMain.mail);
                if (MessageBox.Show("Bạn muốn cập nhật thông tin khách hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busKhachHang.CapNhatKhachHang(kh))
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                        resetValue();
                        LoadGridView_KhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thất bại");
                    }
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Nữ";
            if (rdoNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính khách hàng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txtSdt.Text, txtHoTen.Text, txtDiaChi.Text, gioiTinh, frmMain.mail);
                if (MessageBox.Show("Bạn muốn thêm khách hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busKhachHang.ThemKhachHang(kh))
                    {
                        MessageBox.Show("Thêm khách hàng thành công");
                        resetValue();
                        LoadGridView_KhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại");
                    }
                }

            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValue();
            LoadGridView_KhachHang();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            resetValue();
            LoadGridView_KhachHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chức năng quản lý khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dtgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow rows = this.dtgvKH.Rows[e.RowIndex];
                if(rows.Cells[1].Value.ToString().Count()==0)
                {
                    MessageBox.Show("Không tồn tại dữ liệu");
                    resetValue();
                }    
                rdoNu.Enabled = true;
                rdoNam.Enabled = true;
                txtSdt.Enabled = false;
                txtHoTen.Enabled = true;
                txtDiaChi.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                txtDiaChi.Text = rows.Cells[2].Value.ToString();
                txtHoTen.Text = rows.Cells[1].Value.ToString();
                txtSdt.Text = rows.Cells[0].Value.ToString();
                if (rows.Cells[3].Value.ToString() == "Nữ")
                {
                    rdoNu.Checked = true;
                }
                else
                {
                    rdoNam.Checked = true;
                }
            }
        }
    }
}

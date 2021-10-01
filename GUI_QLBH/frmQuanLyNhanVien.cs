using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLBH;
using BUS_QLBH;

namespace GUI_QLBH
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadGridView_NhanVien();
            resetValue();
        }
        private void loadGridView_NhanVien()
        {
            dtgvNV.DataSource = busNhanVien.DanhSachNhanVien();
            dtgvNV.Columns[0].HeaderText = "Mã nhân viên";
            dtgvNV.Columns[1].HeaderText = "Tên nhân viên";
            dtgvNV.Columns[2].HeaderText = "Email";
            dtgvNV.Columns[3].HeaderText = "Địa chỉ";
            dtgvNV.Columns[4].HeaderText = "Vai trò";
            dtgvNV.Columns[5].HeaderText = "Tình trạng";
            dtgvNV.Columns[6].HeaderText = "Giới tính";
        }
        void resetValue()
        {
            txtDiaChi.Text = null;
            txtEmail.Text = null;
            txtTimKiem.Text = "--Nhập tên nhân viên cần tìm--";
            txtTenNhanVien.Text = null;
            txtEmail.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtDiaChi.Enabled = false;
            rdoHoatDong.Checked = false;
            rdoNam.Checked = false;
            rdoNgungHoatDong.Checked = false;
            rdoNhanVien.Checked = false;
            rdoNu.Checked = false;
            rdoQuanTri.Checked = false;
            btnThoat.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            rdoHoatDong.Enabled = false;
            rdoNam.Enabled = false;
            rdoNgungHoatDong.Enabled = false;
            rdoNhanVien.Enabled = false;
            rdoNu.Enabled = false;
            rdoQuanTri.Enabled = false;
            txtEmail.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = busNhanVien.TimKiemNhanVien(txtTimKiem.Text);
            if (txtTimKiem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    dtgvNV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Tên nhân viên không tồn tại! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTimKiem.Text = "--Nhập tên nhân viên--";

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = null;
            txtEmail.Text = null;
            txtTimKiem.Text = "--Nhập tên nhân viên cần tìm--";
            txtTenNhanVien.Text = null;
            txtEmail.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtDiaChi.Enabled = true;
            rdoHoatDong.Enabled = true;
            rdoNam.Enabled = true;
            rdoNgungHoatDong.Enabled = true;
            rdoNhanVien.Enabled = true;
            rdoNu.Enabled = true;
            rdoQuanTri.Enabled = true;
            rdoHoatDong.Checked = false;
            rdoNam.Checked = false;
            rdoNgungHoatDong.Checked = false;
            rdoNhanVien.Checked = false;
            rdoNu.Checked = false;
            rdoQuanTri.Checked = false;
            btnThoat.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtEmail.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNhanVien.XoaNhanVien(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadGridView_NhanVien();
                    resetValue();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int role = 0;
            if (rdoQuanTri.Checked == true)
            {
                role = 1;
            }
            string phai = "Nữ";
            if (rdoNam.Checked == true)
            {
                phai = "Nam";
            }
            int tinhTrang = 0;
            if (rdoHoatDong.Checked == true)
            {
                tinhTrang = 1;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập địa chỉ !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên nhân viên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoHoatDong.Checked == false && rdoNgungHoatDong.Checked == false)
            {
                MessageBox.Show("bạn cần chọn tình trạng hoạt động !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoNu.Checked == false && rdoNam.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn giới tính cho nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoQuanTri.Checked == false && rdoNhanVien.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn vai trò !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTenNhanVien.Text, txtDiaChi.Text, role, phai, tinhTrang);
                if (MessageBox.Show("Bạn chắc chắn muốn cập nhật thông tin nhân viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busNhanVien.SuaNhanVien(nv))
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công");
                        resetValue();
                        loadGridView_NhanVien();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thất bại");
                    }
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int role = 0;
            if (rdoQuanTri.Checked == true)
            {
                role = 1;
            }
            string phai = "Nữ";
            if (rdoNam.Checked == true)
            {
                phai = "Nam";
            }
            int tinhTrang = 0;
            if (rdoHoatDong.Checked == true)
            {
                tinhTrang = 1;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Email không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!busNhanVien.IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email bạn vừa nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập địa chỉ !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên nhân viên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoHoatDong.Checked == false && rdoNgungHoatDong.Checked == false)
            {
                MessageBox.Show("bạn cần chọn tình trạng hoạt động !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoNu.Checked == false && rdoNam.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn giới tính cho nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoQuanTri.Checked == false && rdoNhanVien.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn vai trò !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(MessageBox.Show("Bạn muốn thêm nhân viên này ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTenNhanVien.Text, txtDiaChi.Text, role, phai, tinhTrang);
                    if (busNhanVien.ThemNhanVien(nv))
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                        busNhanVien.sendEmail(nv.email, "abc123");
                        resetValue();
                        loadGridView_NhanVien();

                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }
                }    
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValue();
            loadGridView_NhanVien();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            resetValue();
            loadGridView_NhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chức năng quản lý nhân viên ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dtgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex>-1 && dtgvNV.Rows[e.RowIndex].Cells[0].Value.ToString() !="")
            {
                DataGridViewRow row = this.dtgvNV.Rows[e.RowIndex];
                txtDiaChi.Enabled = true;
                txtTenNhanVien.Enabled = true;
                rdoHoatDong.Enabled = true;
                rdoNam.Enabled = true;
                rdoNgungHoatDong.Enabled = true;
                rdoNhanVien.Enabled = true;
                rdoNu.Enabled = true;
                rdoQuanTri.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();             
                if (row.Cells[6].Value.ToString() == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else { rdoNu.Checked = true; }
                if (bool.Parse(row.Cells[4].Value.ToString()) == true)
                {
                    rdoQuanTri.Checked = true;
                }
                else
                {
                    rdoNhanVien.Checked = true;
                }

                if (bool.Parse(row.Cells[5].Value.ToString()) == true)
                {
                    rdoHoatDong.Checked = true;
                }
                else
                {
                    rdoNgungHoatDong.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;
using DTO_QLBH;

namespace GUI_QLBH
{
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }
        BUS_SanPham busSanPham = new BUS_SanPham();
        string fileAddress;
        string fileSavePath;
        string fileName;
        string checkUrlImage;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            if(txtTimKiem.Text== "--Nhập tên sản phẩm cần tìm--"||txtTimKiem.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm");
            }    
            else
            {
                DataTable dt = busSanPham.TimkiemSanPham(txtTimKiem.Text);
                if (dt.Rows.Count>0)
                {
                    dtgvSP.DataSource = dt;
                }    
                else
                {
                    MessageBox.Show("Sản phẩm bạn vừa tìm không tồn tại");
                    txtTimKiem.Text = "";
                    txtTimKiem.Focus();
                }    
                
            }    
        }
        

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            loadGridview_SanPham();
            ReSetValue();
        }
        void loadGridview_SanPham()
        {
            dtgvSP.DataSource = busSanPham.DanhSachSanPham();
            dtgvSP.Columns[0].HeaderText = "Mã sản phẩm";
            dtgvSP.Columns[1].HeaderText = "Tên sản phẩm";
            dtgvSP.Columns[2].HeaderText = "Số lượng";
            dtgvSP.Columns[3].HeaderText = "Đơn giá nhập";
            dtgvSP.Columns[4].HeaderText = "Đơn giá bán";
            dtgvSP.Columns[5].HeaderText = "Hình ảnh";
            dtgvSP.Columns[6].HeaderText = "Ghi chú";
            dtgvSP.Columns[7].HeaderText = "Mã nhân viên";
        }
        void ReSetValue()
        {
            pictureBoxSP.Image = null;
            txtHinh.Text = "";
            txtGhiChu.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            txtMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
            txtTimKiem.Text = "--Nhập tên sản phẩm cần tìm--";
            txtHinh.Enabled = false;
            txtGhiChu.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtMaHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTenHang.Enabled = false;
            btnLuu.Enabled = false;
            btnMoHinh.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pictureBoxSP.Image = null;
            txtHinh.Text = "";
            txtGhiChu.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            txtMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
            txtTimKiem.Text = "--Nhập tên sản phẩm cần tìm--";
            txtGhiChu.Enabled = true;
            txtHinh.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtMaHang.Enabled = false;
            txtSoLuong.Enabled = true;
            txtTenHang.Enabled = true;
            btnLuu.Enabled = true;
            btnMoHinh.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnThoat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            loadGridview_SanPham();
            ReSetValue();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            ReSetValue();
            loadGridview_SanPham();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chức năng quản lý sản phẩm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chức năng quản lý sản phẩm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busSanPham.XoaSanPham(int.Parse(txtMaHang.Text)))
                {
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReSetValue();
                    loadGridview_SanPham();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float donGiaBan;
            float donGiaNhap;
            int soLuong;
            bool IsDonGiaBan = float.TryParse(txtDonGiaBan.Text.Trim().ToString(), out donGiaBan);
            bool IsDonGiaNhap = float.TryParse(txtDonGiaNhap.Text.Trim().ToString(), out donGiaNhap);
            bool IsSoLuong = int.TryParse(txtSoLuong.Text.Trim().ToString(), out soLuong);
            if (!IsDonGiaBan || float.Parse(txtDonGiaBan.Text) < 0)
            {
                MessageBox.Show("Đơn giá bán chỉ nhập số và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!IsDonGiaNhap || float.Parse(txtDonGiaNhap.Text) < 0)
            {
                MessageBox.Show("Đơn giá nhập chỉ nhập số và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!IsSoLuong || int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Số lượng chỉ nhập số và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn hình minh họa cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng ghi chú cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTO_SanPham sp = new DTO_SanPham(int.Parse(txtMaHang.Text),txtTenHang.Text, soLuong, donGiaNhap, donGiaBan, txtHinh.Text, txtGhiChu.Text);
                if (busSanPham.SuaSanPham(sp))
                {
                    if(txtHinh.Text!=checkUrlImage)
                    {
                        File.Copy(fileAddress, fileName, true);
                    }    
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReSetValue();
                    loadGridview_SanPham();
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float donGiaBan;
            float donGiaNhap;
            int soLuong;
            bool IsDonGiaBan = float.TryParse(txtDonGiaBan.Text.Trim().ToString(), out donGiaBan);
            bool IsDonGiaNhap = float.TryParse(txtDonGiaNhap.Text.Trim().ToString(), out donGiaNhap);
            bool IsSoLuong = int.TryParse(txtSoLuong.Text.Trim().ToString(), out soLuong);
            if(!IsDonGiaBan||float.Parse(txtDonGiaBan.Text)<0)
            {
                MessageBox.Show("Đơn giá bán chỉ nhập số và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else if(!IsDonGiaNhap||float.Parse(txtDonGiaNhap.Text)<0)
            {
                MessageBox.Show("Đơn giá nhập chỉ nhập số và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else if(!IsSoLuong||int.Parse(txtSoLuong.Text)<0)
            {
                MessageBox.Show("Số lượng chỉ nhập số và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            else if(txtHinh.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui lòng chọn hình minh họa cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else if(txtGhiChu.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui lòng ghi chú cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            else if(txtTenHang.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui lòng nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                DTO_SanPham sp = new DTO_SanPham(txtTenHang.Text, soLuong, donGiaNhap, donGiaBan, txtHinh.Text, txtGhiChu.Text, frmMain.mail);
                if(busSanPham.ThemSanPham(sp))
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.Copy(fileAddress, fileName, true);
                    ReSetValue();
                    loadGridview_SanPham();
                }    
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }    
        }

        private void btnMoHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = " Bitmap(*.bmp)|*.bmp|JPEG(*jpg)|*.jpg|GIF(*.gif)|*.gif|All Files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình minh họa cho sản phẩm";
            if(dlgOpen.ShowDialog()==DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pictureBoxSP.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                txtHinh.Text = "\\Images\\" + fileName;
            }    
        }

        private void dtgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if(e.RowIndex > -1 )
            {
                DataGridViewRow row = this.dtgvSP.Rows[e.RowIndex];
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnMoHinh.Enabled = true;
                txtDonGiaBan.Enabled = true;
                txtDonGiaNhap.Enabled = true;
                txtGhiChu.Enabled = true;
                txtHinh.Enabled = true;
                txtSoLuong.Enabled = true;
                txtTenHang.Enabled = true;
                txtMaHang.Text = row.Cells[0].Value.ToString();
                txtTenHang.Text= row.Cells[1].Value.ToString();
                txtDonGiaBan.Text= row.Cells[4].Value.ToString(); 
                txtDonGiaNhap.Text= row.Cells[3].Value.ToString();
                txtHinh.Text= row.Cells[5].Value.ToString();
                txtGhiChu.Text= row.Cells[6].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                checkUrlImage = txtHinh.Text;
                pictureBoxSP.Image = Image.FromFile(saveDirectory + row.Cells[5].Value.ToString());
            } 
            else
            {
                MessageBox.Show("Dòng không tồn tại dữ liệu");
            }    
        }
    }
}

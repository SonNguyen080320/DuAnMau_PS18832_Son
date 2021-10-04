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
    public partial class frmThongKeSP : Form
    {
        public frmThongKeSP()
        {
            InitializeComponent();
        }
        BUS_SanPham busSanPham = new BUS_SanPham();
        private void sảnPhẩmNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDrig_ThongKeSP();
        }

        private void sốLượngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadGrid_ThongKeTon();
        }
        public void loadGrid_ThongKeTon()
        {
            dataGridView1.DataSource = busSanPham.thongKeTon();
            dataGridView1.Columns[0].HeaderText = "Tên hàng";
            dataGridView1.Columns[1].HeaderText = "Số lượng";
        }
        public void loadDrig_ThongKeSP()
        {
            dataGridView1.DataSource = busSanPham.thongKeSP();
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Số sản phẩm nhập kho";
        }

        private void frmThongKeSP_Load(object sender, EventArgs e)
        {
            
        }
    }
}

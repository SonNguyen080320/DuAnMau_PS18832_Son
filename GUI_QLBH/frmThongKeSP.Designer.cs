﻿
namespace GUI_QLBH
{
    partial class frmThongKeSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sảnPhẩmNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLượngTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 320);
            this.dataGridView1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmNhậpKhoToolStripMenuItem,
            this.sốLượngTồnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sảnPhẩmNhậpKhoToolStripMenuItem
            // 
            this.sảnPhẩmNhậpKhoToolStripMenuItem.Name = "sảnPhẩmNhậpKhoToolStripMenuItem";
            this.sảnPhẩmNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.sảnPhẩmNhậpKhoToolStripMenuItem.Text = "Sản phẩm nhập kho";
            // 
            // sốLượngTồnToolStripMenuItem
            // 
            this.sốLượngTồnToolStripMenuItem.Name = "sốLượngTồnToolStripMenuItem";
            this.sốLượngTồnToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.sốLượngTồnToolStripMenuItem.Text = "Số lượng tồn";
            // 
            // frmThongKeSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmThongKeSP";
            this.Text = "frmThongKeSP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốLượngTồnToolStripMenuItem;
    }
}
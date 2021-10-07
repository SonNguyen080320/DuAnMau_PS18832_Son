
namespace GUI_QLBH
{
    partial class frmLogin
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.lbquenmatkhau = new System.Windows.Forms.Label();
            this.chboxghinhomatkhau = new System.Windows.Forms.CheckBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtemaildangnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnUnHide = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Lime;
            this.btnthoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnthoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(427, 369);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(172, 51);
            this.btnthoat.TabIndex = 29;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.Lime;
            this.btndangnhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btndangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndangnhap.Location = new System.Drawing.Point(205, 369);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(172, 51);
            this.btndangnhap.TabIndex = 28;
            this.btndangnhap.Text = "ĐĂNG NHẬP";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // lbquenmatkhau
            // 
            this.lbquenmatkhau.AutoSize = true;
            this.lbquenmatkhau.Location = new System.Drawing.Point(441, 325);
            this.lbquenmatkhau.Name = "lbquenmatkhau";
            this.lbquenmatkhau.Size = new System.Drawing.Size(117, 17);
            this.lbquenmatkhau.TabIndex = 27;
            this.lbquenmatkhau.Text = "Quên mật khẩu ?";
            this.lbquenmatkhau.Click += new System.EventHandler(this.lbquenmatkhau_Click);
            // 
            // chboxghinhomatkhau
            // 
            this.chboxghinhomatkhau.AutoSize = true;
            this.chboxghinhomatkhau.Location = new System.Drawing.Point(277, 321);
            this.chboxghinhomatkhau.Name = "chboxghinhomatkhau";
            this.chboxghinhomatkhau.Size = new System.Drawing.Size(142, 21);
            this.chboxghinhomatkhau.TabIndex = 26;
            this.chboxghinhomatkhau.Text = "Ghi nhớ mật khẩu";
            this.chboxghinhomatkhau.UseVisualStyleBackColor = true;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(277, 277);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(278, 22);
            this.txtmatkhau.TabIndex = 25;
            // 
            // txtemaildangnhap
            // 
            this.txtemaildangnhap.Location = new System.Drawing.Point(277, 228);
            this.txtemaildangnhap.Name = "txtemaildangnhap";
            this.txtemaildangnhap.Size = new System.Drawing.Size(278, 22);
            this.txtemaildangnhap.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 34);
            this.label3.TabIndex = 23;
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email đăng nhập :";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHide.Image = global::GUI_QLBH.Properties.Resources.hide;
            this.btnHide.Location = new System.Drawing.Point(561, 273);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 31);
            this.btnHide.TabIndex = 31;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnUnHide
            // 
            this.btnUnHide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnHide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnHide.Image = global::GUI_QLBH.Properties.Resources.unhide;
            this.btnUnHide.Location = new System.Drawing.Point(561, 273);
            this.btnUnHide.Name = "btnUnHide";
            this.btnUnHide.Size = new System.Drawing.Size(75, 31);
            this.btnUnHide.TabIndex = 30;
            this.btnUnHide.UseVisualStyleBackColor = false;
            this.btnUnHide.Click += new System.EventHandler(this.btnUnHide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_QLBH.Properties.Resources._140831;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(314, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 119);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 469);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnUnHide);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.lbquenmatkhau);
            this.Controls.Add(this.chboxghinhomatkhau);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtemaildangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label lbquenmatkhau;
        private System.Windows.Forms.CheckBox chboxghinhomatkhau;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtemaildangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUnHide;
        private System.Windows.Forms.Button btnHide;
    }
}
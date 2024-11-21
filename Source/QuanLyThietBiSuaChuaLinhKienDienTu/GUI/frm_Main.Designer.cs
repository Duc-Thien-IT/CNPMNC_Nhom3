namespace GUI
{
    partial class frm_Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
			this.btn_SanPham = new System.Windows.Forms.Button();
			this.btn_Khac = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_TenAmin = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.Label();
			this.avatar = new System.Windows.Forms.PictureBox();
			this.btn_NhanVien = new System.Windows.Forms.Button();
			this.btn_ThongKe = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_NhapHang = new System.Windows.Forms.Button();
			this.btnBanHang = new System.Windows.Forms.Button();
			this.btn_KhachHang = new System.Windows.Forms.Button();
			this.ShowMain = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
			this.ShowMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_SanPham
			// 
			this.btn_SanPham.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_SanPham.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_SanPham.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_SanPham.Location = new System.Drawing.Point(16, 300);
			this.btn_SanPham.Name = "btn_SanPham";
			this.btn_SanPham.Size = new System.Drawing.Size(285, 50);
			this.btn_SanPham.TabIndex = 5;
			this.btn_SanPham.Text = "SẢN PHẨM";
			this.btn_SanPham.UseVisualStyleBackColor = false;
			this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
			// 
			// btn_Khac
			// 
			this.btn_Khac.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_Khac.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Khac.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Khac.Location = new System.Drawing.Point(16, 566);
			this.btn_Khac.Name = "btn_Khac";
			this.btn_Khac.Size = new System.Drawing.Size(285, 50);
			this.btn_Khac.TabIndex = 7;
			this.btn_Khac.Text = "KHÁC";
			this.btn_Khac.UseVisualStyleBackColor = false;
			this.btn_Khac.Click += new System.EventHandler(this.btn_Khac_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(64, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Xin Chào : ";
			// 
			// lb_TenAmin
			// 
			this.lb_TenAmin.AutoSize = true;
			this.lb_TenAmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_TenAmin.ForeColor = System.Drawing.Color.Red;
			this.lb_TenAmin.Location = new System.Drawing.Point(104, 11);
			this.lb_TenAmin.Name = "lb_TenAmin";
			this.lb_TenAmin.Size = new System.Drawing.Size(0, 19);
			this.lb_TenAmin.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Red;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.name);
			this.panel1.Controls.Add(this.avatar);
			this.panel1.Controls.Add(this.btn_NhanVien);
			this.panel1.Controls.Add(this.btn_ThongKe);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.btn_NhapHang);
			this.panel1.Controls.Add(this.btn_SanPham);
			this.panel1.Controls.Add(this.btnBanHang);
			this.panel1.Controls.Add(this.btn_Khac);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lb_TenAmin);
			this.panel1.Controls.Add(this.btn_KhachHang);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(324, 868);
			this.panel1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(63, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "08:30 - 22-11-2024";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(159, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 20);
			this.label2.TabIndex = 18;
			this.label2.Text = "Admin 1";
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name.Location = new System.Drawing.Point(168, 92);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(0, 18);
			this.name.TabIndex = 17;
			// 
			// avatar
			// 
			this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
			this.avatar.Location = new System.Drawing.Point(110, 12);
			this.avatar.Name = "avatar";
			this.avatar.Size = new System.Drawing.Size(102, 74);
			this.avatar.TabIndex = 16;
			this.avatar.TabStop = false;
			// 
			// btn_NhanVien
			// 
			this.btn_NhanVien.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_NhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_NhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_NhanVien.ForeColor = System.Drawing.Color.Black;
			this.btn_NhanVien.Location = new System.Drawing.Point(16, 167);
			this.btn_NhanVien.Name = "btn_NhanVien";
			this.btn_NhanVien.Size = new System.Drawing.Size(285, 50);
			this.btn_NhanVien.TabIndex = 15;
			this.btn_NhanVien.Text = "NHÂN VIÊN";
			this.btn_NhanVien.UseVisualStyleBackColor = false;
			this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click_1);
			// 
			// btn_ThongKe
			// 
			this.btn_ThongKe.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_ThongKe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ThongKe.Location = new System.Drawing.Point(16, 432);
			this.btn_ThongKe.Name = "btn_ThongKe";
			this.btn_ThongKe.Size = new System.Drawing.Size(285, 50);
			this.btn_ThongKe.TabIndex = 14;
			this.btn_ThongKe.Text = "THỐNG KÊ";
			this.btn_ThongKe.UseVisualStyleBackColor = false;
			this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(16, 783);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(285, 50);
			this.button1.TabIndex = 13;
			this.button1.Text = "ĐĂNG XUẤT";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_NhapHang
			// 
			this.btn_NhapHang.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_NhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_NhapHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_NhapHang.Location = new System.Drawing.Point(16, 499);
			this.btn_NhapHang.Name = "btn_NhapHang";
			this.btn_NhapHang.Size = new System.Drawing.Size(285, 50);
			this.btn_NhapHang.TabIndex = 7;
			this.btn_NhapHang.Text = "NHẬP HÀNG";
			this.btn_NhapHang.UseVisualStyleBackColor = false;
			this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
			// 
			// btnBanHang
			// 
			this.btnBanHang.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBanHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBanHang.Location = new System.Drawing.Point(16, 366);
			this.btnBanHang.Name = "btnBanHang";
			this.btnBanHang.Size = new System.Drawing.Size(285, 50);
			this.btnBanHang.TabIndex = 7;
			this.btnBanHang.Text = "BÁN HÀNG";
			this.btnBanHang.UseVisualStyleBackColor = false;
			this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
			// 
			// btn_KhachHang
			// 
			this.btn_KhachHang.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_KhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_KhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_KhachHang.Location = new System.Drawing.Point(16, 232);
			this.btn_KhachHang.Name = "btn_KhachHang";
			this.btn_KhachHang.Size = new System.Drawing.Size(285, 50);
			this.btn_KhachHang.TabIndex = 3;
			this.btn_KhachHang.Text = "KHÁCH HÀNG";
			this.btn_KhachHang.UseVisualStyleBackColor = false;
			this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
			// 
			// ShowMain
			// 
			this.ShowMain.BackColor = System.Drawing.Color.White;
			this.ShowMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ShowMain.Controls.Add(this.pictureBox1);
			this.ShowMain.Location = new System.Drawing.Point(321, 0);
			this.ShowMain.Name = "ShowMain";
			this.ShowMain.Size = new System.Drawing.Size(1887, 856);
			this.ShowMain.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1322, 851);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// frm_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1706, 868);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ShowMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(300, 0);
			this.Name = "frm_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_Main";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
			this.ShowMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_Khac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TenAmin;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel ShowMain;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btn_NhapHang;
		private System.Windows.Forms.Button btn_KhachHang;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_ThongKe;
		private System.Windows.Forms.Button btn_NhanVien;
		private System.Windows.Forms.PictureBox avatar;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
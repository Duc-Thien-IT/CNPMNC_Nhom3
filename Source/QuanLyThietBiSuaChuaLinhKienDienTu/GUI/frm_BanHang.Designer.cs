﻿namespace GUI
{
    partial class frm_BanHang
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
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txttimKiemSanPhamDaChon = new System.Windows.Forms.TextBox();
			this.dgvDanhSachLinhKienDaChon = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTimKiemSanPham = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.dgvSanPham = new System.Windows.Forms.DataGridView();
			this.s = new System.Windows.Forms.GroupBox();
			this.txtTimKhachHang = new System.Windows.Forms.TextBox();
			this.btnThemKhachHang = new System.Windows.Forms.Button();
			this.cboKhachHang = new System.Windows.Forms.ComboBox();
			this.lblUser = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cboPhuongThucThanhToan = new System.Windows.Forms.ComboBox();
			this.btnLuuHoaDon = new System.Windows.Forms.Button();
			this.lblTongCong = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLinhKienDaChon)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
			this.s.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Calisto MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.DarkGreen;
			this.label12.Location = new System.Drawing.Point(331, -4);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(413, 41);
			this.label12.TabIndex = 12;
			this.label12.Text = "QUẢN LÝ BÁN HÀNG";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txttimKiemSanPhamDaChon);
			this.groupBox3.Controls.Add(this.dgvDanhSachLinhKienDaChon);
			this.groupBox3.Location = new System.Drawing.Point(685, 98);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(649, 474);
			this.groupBox3.TabIndex = 22;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chi Tiết Phiếu Bán";
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(13, 426);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(88, 44);
			this.btnXoa.TabIndex = 18;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(228, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 16);
			this.label3.TabIndex = 17;
			this.label3.Text = "Tìm Kiếm";
			// 
			// txttimKiemSanPhamDaChon
			// 
			this.txttimKiemSanPhamDaChon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttimKiemSanPhamDaChon.Location = new System.Drawing.Point(300, 14);
			this.txttimKiemSanPhamDaChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txttimKiemSanPhamDaChon.Multiline = true;
			this.txttimKiemSanPhamDaChon.Name = "txttimKiemSanPhamDaChon";
			this.txttimKiemSanPhamDaChon.Size = new System.Drawing.Size(192, 25);
			this.txttimKiemSanPhamDaChon.TabIndex = 16;
			this.txttimKiemSanPhamDaChon.TextChanged += new System.EventHandler(this.txttimKiemSanPhamDaChon_TextChanged);
			// 
			// dgvDanhSachLinhKienDaChon
			// 
			this.dgvDanhSachLinhKienDaChon.AllowUserToAddRows = false;
			this.dgvDanhSachLinhKienDaChon.AllowUserToDeleteRows = false;
			this.dgvDanhSachLinhKienDaChon.BackgroundColor = System.Drawing.Color.White;
			this.dgvDanhSachLinhKienDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachLinhKienDaChon.Location = new System.Drawing.Point(5, 44);
			this.dgvDanhSachLinhKienDaChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvDanhSachLinhKienDaChon.Name = "dgvDanhSachLinhKienDaChon";
			this.dgvDanhSachLinhKienDaChon.ReadOnly = true;
			this.dgvDanhSachLinhKienDaChon.RowHeadersWidth = 51;
			this.dgvDanhSachLinhKienDaChon.RowTemplate.Height = 24;
			this.dgvDanhSachLinhKienDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDanhSachLinhKienDaChon.Size = new System.Drawing.Size(637, 375);
			this.dgvDanhSachLinhKienDaChon.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtTimKiemSanPham);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtSoLuong);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.dgvSanPham);
			this.groupBox1.Location = new System.Drawing.Point(23, 98);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(657, 474);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh Sách Sản Phẩm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(169, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Tìm Kiếm";
			// 
			// txtTimKiemSanPham
			// 
			this.txtTimKiemSanPham.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiemSanPham.Location = new System.Drawing.Point(241, 14);
			this.txtTimKiemSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTimKiemSanPham.Multiline = true;
			this.txtTimKiemSanPham.Name = "txtTimKiemSanPham";
			this.txtTimKiemSanPham.Size = new System.Drawing.Size(192, 25);
			this.txtTimKiemSanPham.TabIndex = 13;
			this.txtTimKiemSanPham.TextChanged += new System.EventHandler(this.txtTimKiemSanPham_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(331, 439);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Số Lượng";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuong.Location = new System.Drawing.Point(407, 425);
			this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSoLuong.Multiline = true;
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(139, 43);
			this.txtSoLuong.TabIndex = 11;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(552, 425);
			this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(88, 44);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dgvSanPham
			// 
			this.dgvSanPham.AllowUserToAddRows = false;
			this.dgvSanPham.AllowUserToDeleteRows = false;
			this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
			this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSanPham.Location = new System.Drawing.Point(12, 44);
			this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvSanPham.Name = "dgvSanPham";
			this.dgvSanPham.ReadOnly = true;
			this.dgvSanPham.RowHeadersWidth = 51;
			this.dgvSanPham.RowTemplate.Height = 24;
			this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSanPham.Size = new System.Drawing.Size(628, 375);
			this.dgvSanPham.TabIndex = 0;
			// 
			// s
			// 
			this.s.Controls.Add(this.txtTimKhachHang);
			this.s.Controls.Add(this.btnThemKhachHang);
			this.s.Controls.Add(this.cboKhachHang);
			this.s.Controls.Add(this.lblUser);
			this.s.Location = new System.Drawing.Point(23, 577);
			this.s.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.s.Name = "s";
			this.s.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.s.Size = new System.Drawing.Size(657, 175);
			this.s.TabIndex = 23;
			this.s.TabStop = false;
			this.s.Text = "Khách Hàng";
			// 
			// txtTimKhachHang
			// 
			this.txtTimKhachHang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKhachHang.Location = new System.Drawing.Point(136, 21);
			this.txtTimKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTimKhachHang.Multiline = true;
			this.txtTimKhachHang.Name = "txtTimKhachHang";
			this.txtTimKhachHang.Size = new System.Drawing.Size(183, 27);
			this.txtTimKhachHang.TabIndex = 24;
			this.txtTimKhachHang.TextChanged += new System.EventHandler(this.txtTimKhachHang_TextChanged);
			// 
			// btnThemKhachHang
			// 
			this.btnThemKhachHang.Location = new System.Drawing.Point(359, 21);
			this.btnThemKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnThemKhachHang.Name = "btnThemKhachHang";
			this.btnThemKhachHang.Size = new System.Drawing.Size(156, 32);
			this.btnThemKhachHang.TabIndex = 23;
			this.btnThemKhachHang.Text = "Thêm Khách Hàng";
			this.btnThemKhachHang.UseVisualStyleBackColor = true;
			// 
			// cboKhachHang
			// 
			this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboKhachHang.FormattingEnabled = true;
			this.cboKhachHang.Location = new System.Drawing.Point(139, 65);
			this.cboKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboKhachHang.Name = "cboKhachHang";
			this.cboKhachHang.Size = new System.Drawing.Size(180, 28);
			this.cboKhachHang.TabIndex = 22;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(7, 64);
			this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(118, 25);
			this.lblUser.TabIndex = 21;
			this.lblUser.Text = "Khách hàng:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cboPhuongThucThanhToan);
			this.groupBox2.Controls.Add(this.btnLuuHoaDon);
			this.groupBox2.Controls.Add(this.lblTongCong);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(685, 577);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(649, 175);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hóa Đơn";
			// 
			// cboPhuongThucThanhToan
			// 
			this.cboPhuongThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPhuongThucThanhToan.FormattingEnabled = true;
			this.cboPhuongThucThanhToan.Items.AddRange(new object[] {
            "Tiền Mặt",
            "Chuyển Khoản"});
			this.cboPhuongThucThanhToan.Location = new System.Drawing.Point(13, 27);
			this.cboPhuongThucThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboPhuongThucThanhToan.Name = "cboPhuongThucThanhToan";
			this.cboPhuongThucThanhToan.Size = new System.Drawing.Size(160, 24);
			this.cboPhuongThucThanhToan.TabIndex = 23;
			// 
			// btnLuuHoaDon
			// 
			this.btnLuuHoaDon.Location = new System.Drawing.Point(28, 141);
			this.btnLuuHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLuuHoaDon.Name = "btnLuuHoaDon";
			this.btnLuuHoaDon.Size = new System.Drawing.Size(145, 28);
			this.btnLuuHoaDon.TabIndex = 20;
			this.btnLuuHoaDon.Text = "Lưu Hóa Đơn";
			this.btnLuuHoaDon.UseVisualStyleBackColor = true;
			this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
			// 
			// lblTongCong
			// 
			this.lblTongCong.AutoSize = true;
			this.lblTongCong.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongCong.Location = new System.Drawing.Point(172, 85);
			this.lblTongCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTongCong.Name = "lblTongCong";
			this.lblTongCong.Size = new System.Drawing.Size(29, 35);
			this.lblTongCong.TabIndex = 19;
			this.lblTongCong.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 85);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 35);
			this.label5.TabIndex = 18;
			this.label5.Text = "Tổng Cộng:";
			// 
			// frm_BanHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1349, 763);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.s);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label12);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frm_BanHang";
			this.Text = "frm_BanHang";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLinhKienDaChon)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
			this.s.ResumeLayout(false);
			this.s.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttimKiemSanPhamDaChon;
        private System.Windows.Forms.DataGridView dgvDanhSachLinhKienDaChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiemSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox s;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.ComboBox cboPhuongThucThanhToan;
        private System.Windows.Forms.TextBox txtTimKhachHang;
    }
}
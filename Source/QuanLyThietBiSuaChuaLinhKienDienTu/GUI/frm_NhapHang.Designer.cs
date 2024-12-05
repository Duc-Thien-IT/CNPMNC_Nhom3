namespace GUI
{
    partial class frm_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhapHang));
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_TimKiemSP = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuPhieuNhap = new System.Windows.Forms.Button();
            this.number_LanGiao = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_MaPhieuDat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HuyPhieuNhap = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.tb_ThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_MaPN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_XoaChiTietSanPham = new System.Windows.Forms.Button();
            this.btn_LuuChiTietPhieuNhap = new System.Windows.Forms.Button();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaPhieuGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_LanGiao)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calisto MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(410, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(435, 41);
            this.label12.TabIndex = 12;
            this.label12.Text = "QUẢN LÝ NHẬP HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_TimKiemSP);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.dgvSanPham);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 535);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sản Phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(271, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tìm Kiếm";
            // 
            // tb_TimKiemSP
            // 
            this.tb_TimKiemSP.Location = new System.Drawing.Point(342, 22);
            this.tb_TimKiemSP.Name = "tb_TimKiemSP";
            this.tb_TimKiemSP.Size = new System.Drawing.Size(172, 27);
            this.tb_TimKiemSP.TabIndex = 2;
            this.tb_TimKiemSP.TextChanged += new System.EventHandler(this.tb_TimKiemSP_TextChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(323, 453);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(191, 54);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm Sản Phẩm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.MaSP,
            this.TenSP,
            this.Gia,
            this.SoLuongTon,
            this.ThoiGianBaoHanh});
            this.dgvSanPham.Location = new System.Drawing.Point(17, 58);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(497, 389);
            this.dgvSanPham.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.HeaderText = "Thêm";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Width = 125;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.Width = 125;
            // 
            // ThoiGianBaoHanh
            // 
            this.ThoiGianBaoHanh.DataPropertyName = "ThoiGianBaoHanh";
            this.ThoiGianBaoHanh.HeaderText = "Thời Gian Bảo Hành";
            this.ThoiGianBaoHanh.MinimumWidth = 6;
            this.ThoiGianBaoHanh.Name = "ThoiGianBaoHanh";
            this.ThoiGianBaoHanh.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhieuNhap);
            this.groupBox2.Controls.Add(this.btnLuuPhieuNhap);
            this.groupBox2.Controls.Add(this.number_LanGiao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_MaPhieuDat);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_HuyPhieuNhap);
            this.groupBox2.Controls.Add(this.btn_TaoMoi);
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Controls.Add(this.tb_ThanhTien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_MaPN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateNgayKetThuc);
            this.groupBox2.Controls.Add(this.dateNgayBatDau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(545, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 351);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPG,
            this.NgayGiao,
            this.LanGiao,
            this.MaPhieuDat,
            this.ThanhTienPD,
            this.TenNV});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(27, 127);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(603, 158);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellContentClick);
            // 
            // MaPG
            // 
            this.MaPG.DataPropertyName = "MaPhieuGiao";
            this.MaPG.HeaderText = "Mã Phiếu Giao";
            this.MaPG.MinimumWidth = 6;
            this.MaPG.Name = "MaPG";
            this.MaPG.Width = 125;
            // 
            // NgayGiao
            // 
            this.NgayGiao.DataPropertyName = "NgayGiao";
            this.NgayGiao.HeaderText = "Ngày Giao";
            this.NgayGiao.MinimumWidth = 6;
            this.NgayGiao.Name = "NgayGiao";
            this.NgayGiao.Width = 125;
            // 
            // LanGiao
            // 
            this.LanGiao.DataPropertyName = "LanGiao";
            this.LanGiao.HeaderText = "Lần Giao";
            this.LanGiao.MinimumWidth = 6;
            this.LanGiao.Name = "LanGiao";
            this.LanGiao.Width = 125;
            // 
            // MaPhieuDat
            // 
            this.MaPhieuDat.DataPropertyName = "MaPhieuDat";
            this.MaPhieuDat.HeaderText = "Mã Phiếu Đặt";
            this.MaPhieuDat.MinimumWidth = 6;
            this.MaPhieuDat.Name = "MaPhieuDat";
            this.MaPhieuDat.Width = 125;
            // 
            // ThanhTienPD
            // 
            this.ThanhTienPD.DataPropertyName = "ThanhTien";
            this.ThanhTienPD.HeaderText = "Thành Tiền";
            this.ThanhTienPD.MinimumWidth = 6;
            this.ThanhTienPD.Name = "ThanhTienPD";
            this.ThanhTienPD.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 125;
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(317, 300);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(150, 44);
            this.btnLuuPhieuNhap.TabIndex = 23;
            this.btnLuuPhieuNhap.Text = "Lưu Phiếu Nhập";
            this.btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            this.btnLuuPhieuNhap.Click += new System.EventHandler(this.btnLuuPhieuNhap_Click);
            // 
            // number_LanGiao
            // 
            this.number_LanGiao.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_LanGiao.Location = new System.Drawing.Point(399, 58);
            this.number_LanGiao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number_LanGiao.Name = "number_LanGiao";
            this.number_LanGiao.Size = new System.Drawing.Size(49, 27);
            this.number_LanGiao.TabIndex = 22;
            this.number_LanGiao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lần Giao";
            // 
            // tb_MaPhieuDat
            // 
            this.tb_MaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaPhieuDat.Location = new System.Drawing.Point(161, 100);
            this.tb_MaPhieuDat.Multiline = true;
            this.tb_MaPhieuDat.Name = "tb_MaPhieuDat";
            this.tb_MaPhieuDat.Size = new System.Drawing.Size(139, 25);
            this.tb_MaPhieuDat.TabIndex = 20;
            this.tb_MaPhieuDat.TextChanged += new System.EventHandler(this.tb_MaPhieuDat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Đặt Hàng";
            // 
            // btn_HuyPhieuNhap
            // 
            this.btn_HuyPhieuNhap.BackColor = System.Drawing.Color.Red;
            this.btn_HuyPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyPhieuNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HuyPhieuNhap.Location = new System.Drawing.Point(473, 300);
            this.btn_HuyPhieuNhap.Name = "btn_HuyPhieuNhap";
            this.btn_HuyPhieuNhap.Size = new System.Drawing.Size(157, 44);
            this.btn_HuyPhieuNhap.TabIndex = 18;
            this.btn_HuyPhieuNhap.Text = "Hủy Phiếu Nhập";
            this.btn_HuyPhieuNhap.UseVisualStyleBackColor = false;
            this.btn_HuyPhieuNhap.Click += new System.EventHandler(this.btn_HuyPhieuNhap_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.Location = new System.Drawing.Point(199, 300);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(112, 44);
            this.btn_TaoMoi.TabIndex = 16;
            this.btn_TaoMoi.Text = "Tạo Mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(473, 15);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(158, 46);
            this.btn_TimKiem.TabIndex = 15;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // tb_ThanhTien
            // 
            this.tb_ThanhTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ThanhTien.Location = new System.Drawing.Point(503, 97);
            this.tb_ThanhTien.Multiline = true;
            this.tb_ThanhTien.Name = "tb_ThanhTien";
            this.tb_ThanhTien.Size = new System.Drawing.Size(127, 22);
            this.tb_ThanhTien.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thành Tiền";
            // 
            // tb_MaPN
            // 
            this.tb_MaPN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaPN.Location = new System.Drawing.Point(161, 68);
            this.tb_MaPN.Multiline = true;
            this.tb_MaPN.Name = "tb_MaPN";
            this.tb_MaPN.Size = new System.Drawing.Size(139, 25);
            this.tb_MaPN.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Phiếu Nhập";
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKetThuc.Location = new System.Drawing.Point(276, 21);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Size = new System.Drawing.Size(160, 27);
            this.dateNgayKetThuc.TabIndex = 7;
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBatDau.Location = new System.Drawing.Point(44, 21);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Size = new System.Drawing.Size(150, 27);
            this.dateNgayBatDau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_XoaChiTietSanPham);
            this.groupBox3.Controls.Add(this.btn_LuuChiTietPhieuNhap);
            this.groupBox3.Controls.Add(this.dgvChiTietPhieuNhap);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(545, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 260);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phiếu Nhập";
            // 
            // btn_XoaChiTietSanPham
            // 
            this.btn_XoaChiTietSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaChiTietSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaChiTietSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaChiTietSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaChiTietSanPham.Image")));
            this.btn_XoaChiTietSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaChiTietSanPham.Location = new System.Drawing.Point(118, 14);
            this.btn_XoaChiTietSanPham.Name = "btn_XoaChiTietSanPham";
            this.btn_XoaChiTietSanPham.Size = new System.Drawing.Size(261, 51);
            this.btn_XoaChiTietSanPham.TabIndex = 26;
            this.btn_XoaChiTietSanPham.Text = "Xóa Chi Tiết Phiếu Nhập";
            this.btn_XoaChiTietSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaChiTietSanPham.UseVisualStyleBackColor = true;
            this.btn_XoaChiTietSanPham.Click += new System.EventHandler(this.btn_XoaChiTietSanPham_Click);
            // 
            // btn_LuuChiTietPhieuNhap
            // 
            this.btn_LuuChiTietPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuChiTietPhieuNhap.Location = new System.Drawing.Point(385, 14);
            this.btn_LuuChiTietPhieuNhap.Name = "btn_LuuChiTietPhieuNhap";
            this.btn_LuuChiTietPhieuNhap.Size = new System.Drawing.Size(245, 51);
            this.btn_LuuChiTietPhieuNhap.TabIndex = 19;
            this.btn_LuuChiTietPhieuNhap.Text = "Lưu Chi Tiết Phiếu Nhập";
            this.btn_LuuChiTietPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_LuuChiTietPhieuNhap.Click += new System.EventHandler(this.btn_LuuChiTietPhieuNhap_Click);
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuGiao,
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuongGiao,
            this.GiaNhap,
            this.TongTien});
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(17, 72);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgvChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(613, 171);
            this.dgvChiTietPhieuNhap.TabIndex = 0;
            this.dgvChiTietPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_CellClick);
            this.dgvChiTietPhieuNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_CellValueChanged);
            // 
            // MaPhieuGiao
            // 
            this.MaPhieuGiao.DataPropertyName = "MaPhieuGiao";
            this.MaPhieuGiao.HeaderText = "Mã Phiếu Giao";
            this.MaPhieuGiao.MinimumWidth = 6;
            this.MaPhieuGiao.Name = "MaPhieuGiao";
            this.MaPhieuGiao.Width = 125;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSP";
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Width = 125;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSP";
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 125;
            // 
            // SoLuongGiao
            // 
            this.SoLuongGiao.DataPropertyName = "SoLuongGiao";
            this.SoLuongGiao.HeaderText = "Số Lượng Giao";
            this.SoLuongGiao.MinimumWidth = 6;
            this.SoLuongGiao.Name = "SoLuongGiao";
            this.SoLuongGiao.Width = 125;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "Gia";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // frm_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 765);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NhapHang";
            this.Text = "frm_NhapHang";
            this.Load += new System.EventHandler(this.frm_NhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_LanGiao)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_ThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateNgayBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Button btn_LuuChiTietPhieuNhap;
        private System.Windows.Forms.Button btn_HuyPhieuNhap;
        private System.Windows.Forms.TextBox tb_MaPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MaPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown number_LanGiao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuuPhieuNhap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBaoHanh;
        private System.Windows.Forms.TextBox tb_TimKiemSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btn_XoaChiTietSanPham;
    }
}
namespace GUI
{
    partial class frm_DatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DatHang));
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_LuuChiTietPhieuDat = new System.Windows.Forms.Button();
            this.dgvChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            this.btnLuuPhieuDat = new System.Windows.Forms.Button();
            this.tb_MaPhieuDat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HuyPhieuDat = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tb_ThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuDat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calisto MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(433, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(404, 41);
            this.label12.TabIndex = 10;
            this.label12.Text = "QUẢN LÝ ĐẶT HÀNG";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_LuuChiTietPhieuDat);
            this.groupBox3.Controls.Add(this.dgvChiTietPhieuDat);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(554, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 323);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phiếu Đặt";
            // 
            // btn_LuuChiTietPhieuDat
            // 
            this.btn_LuuChiTietPhieuDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LuuChiTietPhieuDat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuChiTietPhieuDat.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuChiTietPhieuDat.Image")));
            this.btn_LuuChiTietPhieuDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LuuChiTietPhieuDat.Location = new System.Drawing.Point(385, 14);
            this.btn_LuuChiTietPhieuDat.Name = "btn_LuuChiTietPhieuDat";
            this.btn_LuuChiTietPhieuDat.Size = new System.Drawing.Size(245, 51);
            this.btn_LuuChiTietPhieuDat.TabIndex = 19;
            this.btn_LuuChiTietPhieuDat.Text = "Lưu Chi Tiết Phiếu Đặt";
            this.btn_LuuChiTietPhieuDat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LuuChiTietPhieuDat.UseVisualStyleBackColor = true;
            this.btn_LuuChiTietPhieuDat.Click += new System.EventHandler(this.btn_LuuChiTietPhieuDat_Click);
            // 
            // dgvChiTietPhieuDat
            // 
            this.dgvChiTietPhieuDat.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuDat.Location = new System.Drawing.Point(17, 72);
            this.dgvChiTietPhieuDat.Name = "dgvChiTietPhieuDat";
            this.dgvChiTietPhieuDat.RowHeadersWidth = 51;
            this.dgvChiTietPhieuDat.RowTemplate.Height = 24;
            this.dgvChiTietPhieuDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhieuDat.Size = new System.Drawing.Size(613, 220);
            this.dgvChiTietPhieuDat.TabIndex = 0;
            this.dgvChiTietPhieuDat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuDat_CellValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.dgvPhieuDat);
            this.groupBox2.Controls.Add(this.btnLuuPhieuDat);
            this.groupBox2.Controls.Add(this.tb_MaPhieuDat);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_HuyPhieuDat);
            this.groupBox2.Controls.Add(this.btn_TaoMoi);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.tb_ThanhTien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateNgayKetThuc);
            this.groupBox2.Controls.Add(this.dateNgayBatDau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(554, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 326);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đặt Hàng";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(485, 67);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(145, 27);
            this.txt_ThanhTien.TabIndex = 24;
            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Location = new System.Drawing.Point(27, 99);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.RowHeadersWidth = 51;
            this.dgvPhieuDat.RowTemplate.Height = 24;
            this.dgvPhieuDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDat.Size = new System.Drawing.Size(603, 158);
            this.dgvPhieuDat.TabIndex = 0;
            this.dgvPhieuDat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDat_CellContentClick);
            // 
            // btnLuuPhieuDat
            // 
            this.btnLuuPhieuDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieuDat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuDat.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPhieuDat.Image")));
            this.btnLuuPhieuDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPhieuDat.Location = new System.Drawing.Point(251, 261);
            this.btnLuuPhieuDat.Name = "btnLuuPhieuDat";
            this.btnLuuPhieuDat.Size = new System.Drawing.Size(199, 55);
            this.btnLuuPhieuDat.TabIndex = 23;
            this.btnLuuPhieuDat.Text = "Lưu Phiếu Đặt";
            this.btnLuuPhieuDat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuPhieuDat.UseVisualStyleBackColor = true;
            this.btnLuuPhieuDat.Click += new System.EventHandler(this.btnLuuPhieuDat_Click);
            // 
            // tb_MaPhieuDat
            // 
            this.tb_MaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaPhieuDat.Location = new System.Drawing.Point(144, 67);
            this.tb_MaPhieuDat.Multiline = true;
            this.tb_MaPhieuDat.Name = "tb_MaPhieuDat";
            this.tb_MaPhieuDat.Size = new System.Drawing.Size(139, 25);
            this.tb_MaPhieuDat.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Đặt Hàng";
            // 
            // btn_HuyPhieuDat
            // 
            this.btn_HuyPhieuDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyPhieuDat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyPhieuDat.Image = ((System.Drawing.Image)(resources.GetObject("btn_HuyPhieuDat.Image")));
            this.btn_HuyPhieuDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HuyPhieuDat.Location = new System.Drawing.Point(456, 261);
            this.btn_HuyPhieuDat.Name = "btn_HuyPhieuDat";
            this.btn_HuyPhieuDat.Size = new System.Drawing.Size(174, 57);
            this.btn_HuyPhieuDat.TabIndex = 18;
            this.btn_HuyPhieuDat.Text = "Hủy Phiếu Đặt";
            this.btn_HuyPhieuDat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_HuyPhieuDat.UseVisualStyleBackColor = true;
            this.btn_HuyPhieuDat.Click += new System.EventHandler(this.btn_HuyPhieuDat_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TaoMoi.AutoSize = true;
            this.btn_TaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoMoi.Image")));
            this.btn_TaoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoMoi.Location = new System.Drawing.Point(94, 261);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(151, 55);
            this.btn_TaoMoi.TabIndex = 16;
            this.btn_TaoMoi.Text = "Tạo Mới";
            this.btn_TaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(485, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 46);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tb_ThanhTien
            // 
            this.tb_ThanhTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ThanhTien.Location = new System.Drawing.Point(503, 99);
            this.tb_ThanhTien.Multiline = true;
            this.tb_ThanhTien.Name = "tb_ThanhTien";
            this.tb_ThanhTien.Size = new System.Drawing.Size(127, 22);
            this.tb_ThanhTien.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thành Tiền";
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKetThuc.Location = new System.Drawing.Point(290, 26);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Size = new System.Drawing.Size(160, 27);
            this.dateNgayKetThuc.TabIndex = 7;
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBatDau.Location = new System.Drawing.Point(58, 26);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Size = new System.Drawing.Size(150, 27);
            this.dateNgayBatDau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_TimKiemSP);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.dgvSanPham);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 535);
            this.groupBox1.TabIndex = 20;
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
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(322, 453);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(192, 56);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm Sản Phẩm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(158, 65);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(235, 27);
            this.cbNhaCungCap.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhà Cung Cấp";
            // 
            // frm_DatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 765);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNhaCungCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_DatHang";
            this.Load += new System.EventHandler(this.frm_DatHang_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuDat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_LuuChiTietPhieuDat;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuDat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhieuDat;
        private System.Windows.Forms.Button btnLuuPhieuDat;
        private System.Windows.Forms.TextBox tb_MaPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HuyPhieuDat;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tb_ThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateNgayBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_TimKiemSP;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBaoHanh;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ThanhTien;
    }
}
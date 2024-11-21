namespace GUI
{
    partial class frm_NhanVien
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
			this.panel7 = new System.Windows.Forms.Panel();
			this.txt_SDT = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txt_NgaySinh = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txt_TenNV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txt_MaNV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_MaTK = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.panel13 = new System.Windows.Forms.Panel();
			this.txtMaTK = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtTenDN = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtQuyen = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel15 = new System.Windows.Forms.Panel();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel12 = new System.Windows.Forms.Panel();
			this.txt_GioiTinh = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_TimKiem = new System.Windows.Forms.Button();
			this.txt_TimKiem = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Moi = new System.Windows.Forms.Button();
			this.btn_Sua = new System.Windows.Forms.Button();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.btn_Them = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel13.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel15.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel12.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox4);
			this.panel2.Location = new System.Drawing.Point(0, 545);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1161, 190);
			this.panel2.TabIndex = 3;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dgv_NhanVien);
			this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(33, 2);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox4.Size = new System.Drawing.Size(1087, 183);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Danh Sách Nhân Viên";
			// 
			// dgv_NhanVien
			// 
			this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.White;
			this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_NhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dgv_NhanVien.Location = new System.Drawing.Point(49, 30);
			this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgv_NhanVien.Name = "dgv_NhanVien";
			this.dgv_NhanVien.RowHeadersWidth = 51;
			this.dgv_NhanVien.RowTemplate.Height = 24;
			this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_NhanVien.Size = new System.Drawing.Size(997, 134);
			this.dgv_NhanVien.TabIndex = 0;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.txt_SDT);
			this.panel7.Controls.Add(this.label5);
			this.panel7.Location = new System.Drawing.Point(413, 190);
			this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(341, 78);
			this.panel7.TabIndex = 3;
			// 
			// txt_SDT
			// 
			this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_SDT.Location = new System.Drawing.Point(148, 14);
			this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_SDT.Multiline = true;
			this.txt_SDT.Name = "txt_SDT";
			this.txt_SDT.Size = new System.Drawing.Size(177, 41);
			this.txt_SDT.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(4, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Số Điện Thoại";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.txt_NgaySinh);
			this.panel6.Controls.Add(this.label4);
			this.panel6.Location = new System.Drawing.Point(413, 21);
			this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(341, 78);
			this.panel6.TabIndex = 4;
			// 
			// txt_NgaySinh
			// 
			this.txt_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_NgaySinh.Location = new System.Drawing.Point(132, 21);
			this.txt_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_NgaySinh.Multiline = true;
			this.txt_NgaySinh.Name = "txt_NgaySinh";
			this.txt_NgaySinh.Size = new System.Drawing.Size(193, 41);
			this.txt_NgaySinh.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Ngày Sinh";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txt_TenNV);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(15, 105);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(389, 78);
			this.panel4.TabIndex = 3;
			// 
			// txt_TenNV
			// 
			this.txt_TenNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenNV.Location = new System.Drawing.Point(163, 12);
			this.txt_TenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_TenNV.Multiline = true;
			this.txt_TenNV.Name = "txt_TenNV";
			this.txt_TenNV.Size = new System.Drawing.Size(209, 41);
			this.txt_TenNV.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên Nhân Viên";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txt_MaNV);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(15, 21);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(389, 78);
			this.panel3.TabIndex = 2;
			// 
			// txt_MaNV
			// 
			this.txt_MaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MaNV.Location = new System.Drawing.Point(163, 21);
			this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_MaNV.Multiline = true;
			this.txt_MaNV.Name = "txt_MaNV";
			this.txt_MaNV.ReadOnly = true;
			this.txt_MaNV.Size = new System.Drawing.Size(209, 41);
			this.txt_MaNV.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Nhân Viên";
			// 
			// txt_MaTK
			// 
			this.txt_MaTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MaTK.Location = new System.Drawing.Point(163, 14);
			this.txt_MaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_MaTK.Multiline = true;
			this.txt_MaTK.Name = "txt_MaTK";
			this.txt_MaTK.Size = new System.Drawing.Size(209, 41);
			this.txt_MaTK.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.btn_TimKiem);
			this.panel1.Controls.Add(this.txt_TimKiem);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1229, 539);
			this.panel1.TabIndex = 2;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel13);
			this.groupBox3.Controls.Add(this.btnLuu);
			this.groupBox3.Controls.Add(this.panel5);
			this.groupBox3.Controls.Add(this.panel9);
			this.groupBox3.Controls.Add(this.panel10);
			this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(793, 90);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(407, 447);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin tài khoản";
			// 
			// panel13
			// 
			this.panel13.Controls.Add(this.txtMaTK);
			this.panel13.Controls.Add(this.label11);
			this.panel13.Location = new System.Drawing.Point(20, 273);
			this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(381, 68);
			this.panel13.TabIndex = 10;
			// 
			// txtMaTK
			// 
			this.txtMaTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaTK.Location = new System.Drawing.Point(164, 11);
			this.txtMaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMaTK.Multiline = true;
			this.txtMaTK.Name = "txtMaTK";
			this.txtMaTK.ReadOnly = true;
			this.txtMaTK.Size = new System.Drawing.Size(177, 41);
			this.txtMaTK.TabIndex = 1;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(4, 15);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(122, 23);
			this.label11.TabIndex = 0;
			this.label11.Text = "Mã tài khoản";
			// 
			// btnLuu
			// 
			this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLuu.Location = new System.Drawing.Point(159, 378);
			this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(107, 46);
			this.btnLuu.TabIndex = 9;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.txtTenDN);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(20, 21);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(381, 78);
			this.panel5.TabIndex = 7;
			// 
			// txtTenDN
			// 
			this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenDN.Location = new System.Drawing.Point(164, 17);
			this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTenDN.Multiline = true;
			this.txtTenDN.Name = "txtTenDN";
			this.txtTenDN.Size = new System.Drawing.Size(177, 41);
			this.txtTenDN.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên Đăng Nhập";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.txtQuyen);
			this.panel9.Controls.Add(this.label7);
			this.panel9.Location = new System.Drawing.Point(20, 190);
			this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(381, 78);
			this.panel9.TabIndex = 6;
			// 
			// txtQuyen
			// 
			this.txtQuyen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuyen.Location = new System.Drawing.Point(164, 14);
			this.txtQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtQuyen.Multiline = true;
			this.txtQuyen.Name = "txtQuyen";
			this.txtQuyen.Size = new System.Drawing.Size(175, 41);
			this.txtQuyen.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(4, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Quyền";
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.txtMatKhau);
			this.panel10.Controls.Add(this.label8);
			this.panel10.Location = new System.Drawing.Point(20, 105);
			this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(381, 78);
			this.panel10.TabIndex = 8;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau.Location = new System.Drawing.Point(164, 17);
			this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMatKhau.Multiline = true;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(175, 41);
			this.txtMatKhau.TabIndex = 1;
			this.txtMatKhau.UseSystemPasswordChar = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(4, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "Mật Khẩu";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel11);
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Controls.Add(this.panel4);
			this.groupBox2.Controls.Add(this.panel6);
			this.groupBox2.Controls.Add(this.panel7);
			this.groupBox2.Controls.Add(this.panel15);
			this.groupBox2.Controls.Add(this.panel8);
			this.groupBox2.Controls.Add(this.panel12);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 90);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(775, 341);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin nhân viên";
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.txtDiaChi);
			this.panel11.Controls.Add(this.label9);
			this.panel11.Location = new System.Drawing.Point(413, 273);
			this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(341, 64);
			this.panel11.TabIndex = 6;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(77, 14);
			this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDiaChi.Multiline = true;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(248, 41);
			this.txtDiaChi.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(3, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 23);
			this.label9.TabIndex = 0;
			this.label9.Text = "Địa chỉ";
			// 
			// panel15
			// 
			this.panel15.Controls.Add(this.txt_Email);
			this.panel15.Controls.Add(this.label14);
			this.panel15.Location = new System.Drawing.Point(413, 105);
			this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(341, 78);
			this.panel15.TabIndex = 5;
			// 
			// txt_Email
			// 
			this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Email.Location = new System.Drawing.Point(99, 21);
			this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Email.Multiline = true;
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(228, 41);
			this.txt_Email.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(4, 30);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(61, 23);
			this.label14.TabIndex = 0;
			this.label14.Text = "Email";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.txt_MaTK);
			this.panel8.Controls.Add(this.label6);
			this.panel8.Location = new System.Drawing.Point(15, 273);
			this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(389, 64);
			this.panel8.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "Mã Tài Khoản";
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.txt_GioiTinh);
			this.panel12.Controls.Add(this.label10);
			this.panel12.Location = new System.Drawing.Point(15, 190);
			this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(389, 78);
			this.panel12.TabIndex = 4;
			// 
			// txt_GioiTinh
			// 
			this.txt_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_GioiTinh.Location = new System.Drawing.Point(163, 14);
			this.txt_GioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_GioiTinh.Multiline = true;
			this.txt_GioiTinh.Name = "txt_GioiTinh";
			this.txt_GioiTinh.Size = new System.Drawing.Size(209, 41);
			this.txt_GioiTinh.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(4, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 23);
			this.label10.TabIndex = 0;
			this.label10.Text = "Giới Tính";
			// 
			// btn_TimKiem
			// 
			this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TimKiem.Location = new System.Drawing.Point(1064, 48);
			this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_TimKiem.Name = "btn_TimKiem";
			this.btn_TimKiem.Size = new System.Drawing.Size(111, 36);
			this.btn_TimKiem.TabIndex = 11;
			this.btn_TimKiem.Text = "Tìm Kiếm";
			this.btn_TimKiem.UseVisualStyleBackColor = true;
			this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
			// 
			// txt_TimKiem
			// 
			this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TimKiem.Location = new System.Drawing.Point(793, 50);
			this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_TimKiem.Multiline = true;
			this.txt_TimKiem.Name = "txt_TimKiem";
			this.txt_TimKiem.Size = new System.Drawing.Size(265, 34);
			this.txt_TimKiem.TabIndex = 10;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Moi);
			this.groupBox1.Controls.Add(this.btn_Sua);
			this.groupBox1.Controls.Add(this.btn_Xoa);
			this.groupBox1.Controls.Add(this.btn_Them);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 438);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(775, 98);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chức Năng";
			// 
			// btn_Moi
			// 
			this.btn_Moi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Moi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Moi.Location = new System.Drawing.Point(492, 30);
			this.btn_Moi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Moi.Name = "btn_Moi";
			this.btn_Moi.Size = new System.Drawing.Size(103, 46);
			this.btn_Moi.TabIndex = 7;
			this.btn_Moi.Text = "Mới";
			this.btn_Moi.UseVisualStyleBackColor = true;
			// 
			// btn_Sua
			// 
			this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Sua.Location = new System.Drawing.Point(205, 30);
			this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(103, 46);
			this.btn_Sua.TabIndex = 6;
			this.btn_Sua.Text = "Sửa";
			this.btn_Sua.UseVisualStyleBackColor = true;
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.BackColor = System.Drawing.Color.Red;
			this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_Xoa.Location = new System.Drawing.Point(343, 30);
			this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(101, 46);
			this.btn_Xoa.TabIndex = 5;
			this.btn_Xoa.Text = "Xóa";
			this.btn_Xoa.UseVisualStyleBackColor = false;
			// 
			// btn_Them
			// 
			this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_Them.Location = new System.Drawing.Point(59, 30);
			this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(107, 46);
			this.btn_Them.TabIndex = 4;
			this.btn_Them.Text = "Thêm";
			this.btn_Them.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label12.Location = new System.Drawing.Point(355, 24);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(411, 42);
			this.label12.TabIndex = 14;
			this.label12.Text = "QUẢN LÝ NHÂN VIÊN";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// frm_NhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1232, 766);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frm_NhanVien";
			this.Text = "frm_NhanVien";
			this.panel2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.panel13.ResumeLayout(false);
			this.panel13.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			this.panel15.ResumeLayout(false);
			this.panel15.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Moi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txt_GioiTinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
	}
}
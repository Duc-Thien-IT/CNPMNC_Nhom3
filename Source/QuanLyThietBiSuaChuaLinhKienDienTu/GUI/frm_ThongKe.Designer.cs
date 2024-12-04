    
namespace GUI
{
    partial class frm_ThongKe
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblTotalRevenue = new System.Windows.Forms.Label();
			this.lblTotalOrders = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnInHoaDon = new System.Windows.Forms.Button();
			this.dgvOrdersByStatus = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radHoaDon = new System.Windows.Forms.RadioButton();
			this.radHoaDonSuaChua = new System.Windows.Forms.RadioButton();
			this.btnLoc = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrdersByStatus)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblTotalRevenue);
			this.groupBox3.Controls.Add(this.lblTotalOrders);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(24, 653);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(1035, 167);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông Sô";
			// 
			// lblTotalRevenue
			// 
			this.lblTotalRevenue.AutoSize = true;
			this.lblTotalRevenue.Location = new System.Drawing.Point(8, 55);
			this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotalRevenue.Name = "lblTotalRevenue";
			this.lblTotalRevenue.Size = new System.Drawing.Size(0, 26);
			this.lblTotalRevenue.TabIndex = 1;
			// 
			// lblTotalOrders
			// 
			this.lblTotalOrders.AutoSize = true;
			this.lblTotalOrders.Location = new System.Drawing.Point(8, 28);
			this.lblTotalOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotalOrders.Name = "lblTotalOrders";
			this.lblTotalOrders.Size = new System.Drawing.Size(0, 26);
			this.lblTotalOrders.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnInHoaDon);
			this.groupBox2.Controls.Add(this.dgvOrdersByStatus);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(24, 280);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(1035, 350);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh Sách";
			// 
			// btnInHoaDon
			// 
			this.btnInHoaDon.Location = new System.Drawing.Point(883, 297);
			this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(4);
			this.btnInHoaDon.Name = "btnInHoaDon";
			this.btnInHoaDon.Size = new System.Drawing.Size(144, 48);
			this.btnInHoaDon.TabIndex = 1;
			this.btnInHoaDon.Text = "In Hóa Đơn";
			this.btnInHoaDon.UseVisualStyleBackColor = true;
			this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
			// 
			// dgvOrdersByStatus
			// 
			this.dgvOrdersByStatus.AllowUserToAddRows = false;
			this.dgvOrdersByStatus.AllowUserToDeleteRows = false;
			this.dgvOrdersByStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrdersByStatus.Location = new System.Drawing.Point(8, 48);
			this.dgvOrdersByStatus.Margin = new System.Windows.Forms.Padding(4);
			this.dgvOrdersByStatus.Name = "dgvOrdersByStatus";
			this.dgvOrdersByStatus.ReadOnly = true;
			this.dgvOrdersByStatus.RowHeadersWidth = 51;
			this.dgvOrdersByStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrdersByStatus.Size = new System.Drawing.Size(1019, 241);
			this.dgvOrdersByStatus.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radHoaDon);
			this.groupBox1.Controls.Add(this.radHoaDonSuaChua);
			this.groupBox1.Controls.Add(this.btnLoc);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpEndDate);
			this.groupBox1.Controls.Add(this.dtpStartDate);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(32, 105);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(1024, 154);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// radHoaDon
			// 
			this.radHoaDon.AutoSize = true;
			this.radHoaDon.Checked = true;
			this.radHoaDon.Location = new System.Drawing.Point(536, 31);
			this.radHoaDon.Margin = new System.Windows.Forms.Padding(4);
			this.radHoaDon.Name = "radHoaDon";
			this.radHoaDon.Size = new System.Drawing.Size(233, 30);
			this.radHoaDon.TabIndex = 10;
			this.radHoaDon.TabStop = true;
			this.radHoaDon.Text = "Danh Sách Hóa Đơn";
			this.radHoaDon.UseVisualStyleBackColor = true;
			this.radHoaDon.CheckedChanged += new System.EventHandler(this.btnLoc_Click);
			// 
			// radHoaDonSuaChua
			// 
			this.radHoaDonSuaChua.AutoSize = true;
			this.radHoaDonSuaChua.Location = new System.Drawing.Point(536, 70);
			this.radHoaDonSuaChua.Margin = new System.Windows.Forms.Padding(4);
			this.radHoaDonSuaChua.Name = "radHoaDonSuaChua";
			this.radHoaDonSuaChua.Size = new System.Drawing.Size(336, 30);
			this.radHoaDonSuaChua.TabIndex = 8;
			this.radHoaDonSuaChua.Text = "Danh Sách Hóa Đơn Sửa Chửa";
			this.radHoaDonSuaChua.UseVisualStyleBackColor = true;
			this.radHoaDonSuaChua.CheckedChanged += new System.EventHandler(this.btnLoc_Click);
			// 
			// btnLoc
			// 
			this.btnLoc.Location = new System.Drawing.Point(921, 38);
			this.btnLoc.Margin = new System.Windows.Forms.Padding(4);
			this.btnLoc.Name = "btnLoc";
			this.btnLoc.Size = new System.Drawing.Size(105, 85);
			this.btnLoc.TabIndex = 4;
			this.btnLoc.Text = "Lọc";
			this.btnLoc.UseVisualStyleBackColor = true;
			this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 90);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 26);
			this.label2.TabIndex = 3;
			this.label2.Text = "Đến Ngày";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Từ Ngày";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEndDate.Location = new System.Drawing.Point(161, 84);
			this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(265, 32);
			this.dtpEndDate.TabIndex = 1;
			this.dtpEndDate.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStartDate.Location = new System.Drawing.Point(161, 31);
			this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(265, 32);
			this.dtpStartDate.TabIndex = 0;
			this.dtpStartDate.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.ForestGreen;
			this.label3.Location = new System.Drawing.Point(442, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 51);
			this.label3.TabIndex = 8;
			this.label3.Text = "THỐNG KÊ";
			// 
			// frm_ThongKe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1211, 833);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_ThongKe";
			this.Text = "frm_ThongKe";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrdersByStatus)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.DataGridView dgvOrdersByStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.RadioButton radHoaDon;
        private System.Windows.Forms.RadioButton radHoaDonSuaChua;
		private System.Windows.Forms.Label label3;
	}
}
﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Main : Form
    {
        private readonly NhanVien_BLL nhanVienBLL;
        public frm_Main()
        {
            InitializeComponent();
            nhanVienBLL = new NhanVien_BLL();
            KiemTraVaiTro();
        }
        private void KiemTraVaiTro()
        {
            string vaiTro = nhanVienBLL.LayVaiTroNV(frm_DangNhap.tenDN);
            if (!vaiTro.Equals("Quản lý"))
            {
                btnTaiKhoan.Enabled = false;
            }    
        }
        private void btn_KhachHang_Click(object sender, EventArgs e)
        {

            frm_KhachHang f = new frm_KhachHang();
            ShowMain.Controls.Clear();
            ShowMain.Show();
            f.TopLevel = false;
            ShowMain.Controls.Add(f);
            f.Show();
        }

       

      

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            frm_SanPham f = new frm_SanPham();
            ShowMain.Controls.Clear();
            ShowMain.Show();
            f.TopLevel = false;
            ShowMain.Controls.Add(f);
            f.Show();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            frm_NhapHang f = new frm_NhapHang();
            ShowMain.Controls.Clear();
            ShowMain.Show();
            f.TopLevel = false;
            ShowMain.Controls.Add(f);
            f.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frm_BanHang f = new frm_BanHang();
            ShowMain.Controls.Clear();
            ShowMain.Show();
            f.TopLevel = false;
            ShowMain.Controls.Add(f);
            f.Show();
        }

        private void btn_Khac_Click(object sender, EventArgs e)
        {

            frm_Khac f = new frm_Khac();
            ShowMain.Controls.Clear();
            ShowMain.Show();
            f.TopLevel = false;
            ShowMain.Controls.Add(f);
            f.Show();
        }

		private void btn_ThongKe_Click(object sender, EventArgs e)
		{
			frm_ThongKe f = new frm_ThongKe();
			ShowMain.Controls.Clear();
			ShowMain.Show();
			f.TopLevel = false;
			ShowMain.Controls.Add(f);
			f.Show();
		}

		private void btn_NhanVien_Click_1(object sender, EventArgs e)
		{
			frm_NhanVien f = new frm_NhanVien();
			ShowMain.Controls.Clear();
			ShowMain.Show();
			f.TopLevel = false;
			ShowMain.Controls.Add(f);
			f.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
                frm_DangNhap loginForm = new frm_DangNhap();
                loginForm.Show();
                this.Hide();
			}

		}

		private void btnDatHang_Click(object sender, EventArgs e)
		{
			frm_DatHang f = new frm_DatHang();
			ShowMain.Controls.Clear();
			ShowMain.Show();
			f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Ẩn viền form để đồng nhất giao diện
            f.Dock = DockStyle.Fill;
            ShowMain.Controls.Add(f);
            f.Show();
		}

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_TaiKhoan f = new frm_TaiKhoan();
            ShowMain.Controls.Clear();
            ShowMain.Show();
            f.TopLevel = false;
            ShowMain.Controls.Add(f);
            f.Show();
        
        }
    }
}

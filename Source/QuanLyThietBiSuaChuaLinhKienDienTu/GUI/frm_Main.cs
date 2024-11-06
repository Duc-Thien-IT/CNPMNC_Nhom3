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
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            frm_NhanVien f = new frm_NhanVien();
            ShowMain.Controls.Clear();
            ShowMain.Show();
            f.TopLevel = false;
            ShowMain.Controls.Add(f);
            f.Show();
        }

        private void picture_Exit_Click(object sender, EventArgs e)
        {
            DialogResult KQ;
            KQ = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (KQ == DialogResult.OK)
            {
                this.Close();
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

        
    }
}

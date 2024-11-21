using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BLL;

namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        private readonly Login_BLL Login_BLL;
        public frm_DangNhap()
        {
            InitializeComponent();
            Login_BLL = new Login_BLL();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txt_TenDN.Text;
                string passWord = txt_MK.Text;
                
                if (Login_BLL.CheckLogin(userName,passWord))
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Main frm = new frm_Main();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult KQ;
            KQ =  MessageBox.Show("Bạn có muốn thoát khỏi chương trình không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(KQ == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;

            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

      

       

      

        

       

        

       
    }
}

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

namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
           
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

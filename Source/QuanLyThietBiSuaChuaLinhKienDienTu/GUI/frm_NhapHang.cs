using DAL;
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
    public partial class frm_NhapHang : Form
    {
        private readonly NhaCungCap_DAL spBLL;
       
        public frm_NhapHang()
        {
            InitializeComponent();
            spBLL = new NhaCungCap_DAL();
            LoadSanPham();
            LoadNhaCungCap();
        }

        private void LoadSanPham()
        {
           
            try
            {
                DataTable dtSanPham = spBLL.GetAllSanPham();

               dgvSanPham.DataSource = dtSanPham;

                dgvSanPham.Columns["MaSP"].HeaderText = "Mã SP";
                dgvSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                dgvSanPham.Columns["Gia"].HeaderText = "Giá";
                dgvSanPham.Columns["SoLuongTon"].HeaderText = "Số Lượng";
                dgvSanPham.Columns["TenDanhMuc"].HeaderText = "Loại SP";

                dgvSanPham.Columns["MaSP"].Width = 80;
                dgvSanPham.Columns["TenSP"].Width = 240;
                dgvSanPham.Columns["Gia"].Width = 140;
                dgvSanPham.Columns["SoLuongTon"].Width = 80;
                dgvSanPham.Columns["ThoiGianBaoHanh"].Width = 130;
                dgvSanPham.Columns["TenDanhMuc"].Width = 170;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadNhaCungCap()
        {
            DataTable dt = spBLL.GetAllNhaCungCap();
            cbNhaCungUng.DataSource = dt;   
            cbNhaCungUng.DisplayMember = "TenNCC";
            
   
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frm_SanPham : Form
    {
        private readonly SanPham_BLL spBLL;

        public frm_SanPham()
        {
            InitializeComponent();
            spBLL = new SanPham_BLL();
            this.Load += frm_SanPham_Load;
            this.btn_Them.Click += btn_Them_Click;
            this.btn_Sua.Click += btn_Sua_Click;
            this.btn_Xoa.Click += btn_Xoa_Click;
        }

        void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMasp.Text; 
                bool result = spBLL.DeleteSanPham(maSP);  
                if (result)
                {
                    MessageBox.Show("Sản phẩm đã được ẩn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadSanPham(); 
                }
                else
                {
                    MessageBox.Show("Lỗi khi ẩn sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMasp.Text;  // Lấy mã sản phẩm cần sửa
                string tenSP = txtTensp.Text;
                decimal gia = decimal.Parse(txtGiaban.Text);

                int thoiGianBaoHanh = 0;
                if (!int.TryParse(txtTgbh.Text, out thoiGianBaoHanh) || thoiGianBaoHanh <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số tháng bảo hành hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maDanhMuc = cbbLoaisp.SelectedValue.ToString();

                bool result = spBLL.UpdateSanPham(maSP, tenSP, gia, thoiGianBaoHanh, maDanhMuc);

                if (result)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadSanPham(); // Tải lại danh sách sản phẩm sau khi sửa thông tin
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTensp.Text;
                if (string.IsNullOrEmpty(tenSP))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal gia;
                if (!decimal.TryParse(txtGiaban.Text, out gia) || gia <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int thoiGianBaoHanh;
                if (!int.TryParse(txtTgbh.Text, out thoiGianBaoHanh) || thoiGianBaoHanh <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số tháng bảo hành hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maDanhMuc = cbbLoaisp.SelectedValue == null ? null : cbbLoaisp.SelectedValue.ToString();
                if (string.IsNullOrEmpty(maDanhMuc))
                {
                    MessageBox.Show("Vui lòng chọn danh mục sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool result = spBLL.AddSanPham(tenSP, gia, thoiGianBaoHanh, maDanhMuc);

                if (result)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_SanPham_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            try
            {
                DataTable dtSanPham = spBLL.GetAllSanPham();

                dataSp.DataSource = dtSanPham;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhMuc()
        {
            try
            {
                // Lấy danh sách danh mục sản phẩm từ BLL
                DataTable dtDanhMuc = spBLL.GetAllDanhMuc();

                // Đưa danh sách vào ComboBox
                cbbLoaisp.DataSource = dtDanhMuc;
                cbbLoaisp.DisplayMember = "TenDanhMuc"; // Hiển thị tên danh mục
                cbbLoaisp.ValueMember = "MaDanhMuc"; // Lưu giá trị là mã danh mục
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtMasp.Clear();
            txtTensp.Clear();
            txtGiaban.Clear();
            txtTgbh.Clear();  
            cbbLoaisp.SelectedIndex = -1;
        }

    }
}

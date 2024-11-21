using System;
using System.Windows.Forms;
using BLL;
using System.Data;

namespace GUI
{
    public partial class frm_KhachHang : Form
    {
        private readonly KhachHang_BLL khachHangBLL;

        public frm_KhachHang()
        {
            InitializeComponent();
            khachHangBLL = new KhachHang_BLL();
            LoadKhachHangData();
            SetupEventHandlers();
        }

        private void LoadKhachHangData()
        {
            dgv_NhanVien.DataSource = khachHangBLL.GetAllKhachHang();
        }

        private void SetupEventHandlers()
        {
            btn_Them.Click += btn_Them_Click;
            btn_Sua.Click += btn_Sua_Click;
            btn_Xoa.Click += btn_Xoa_Click;
            btn_Moi.Click += btn_Moi_Click;
            btn_TimKiem.Click += btn_TimKiem_Click;
            dgv_NhanVien.SelectionChanged += dgv_NhanVien_SelectionChanged;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txt_MaNV.Text;
                string tenKH = txt_TenNV.Text;
                string email = txt_Email.Text;
                string sdt = txt_SDT.Text;
                string diaChi = txt_GioiTinh.Text; // Note: This should be renamed to txt_DiaChi in the designer

                if (khachHangBLL.AddKhachHang(maKH, tenKH, email, sdt, diaChi))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadKhachHangData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txt_MaNV.Text;
                string tenKH = txt_TenNV.Text;
                string email = txt_Email.Text;
                string sdt = txt_SDT.Text;
                string diaChi = txt_GioiTinh.Text; // Note: This should be renamed to txt_DiaChi in the designer

                if (khachHangBLL.UpdateKhachHang(maKH, tenKH, email, sdt, diaChi))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    LoadKhachHangData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txt_MaNV.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (khachHangBLL.DeleteKhachHang(maKH))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadKhachHangData();
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Moi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txt_TimKiem.Text.Trim();
                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable searchResults = khachHangBLL.SearchKhachHang(searchTerm);

                if (searchResults.Rows.Count > 0)
                {
                    dgv_NhanVien.DataSource = searchResults;
                    MessageBox.Show($"Tìm thấy {searchResults.Rows.Count} kết quả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, you can reload all employees here
                    // LoadNhanVienData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_NhanVien.SelectedRows[0];
                txt_MaNV.Text = row.Cells["MaKH"].Value.ToString();
                txt_TenNV.Text = row.Cells["TenKH"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                txt_GioiTinh.Text = row.Cells["DiaChi"].Value.ToString(); // Note: This should be renamed to txt_DiaChi in the designer
            }
        }

        private void ClearInputs()
        {
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_Email.Clear();
            txt_SDT.Clear();
            txt_GioiTinh.Clear();
            txt_TimKiem.Clear();
        }

   
    }
}
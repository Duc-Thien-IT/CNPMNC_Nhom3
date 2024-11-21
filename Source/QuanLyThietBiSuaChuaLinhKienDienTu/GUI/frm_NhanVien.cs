using System;
using System.Windows.Forms;
using System.Data;
using BLL;

namespace GUI
{
    public partial class frm_NhanVien : Form
    {
        
        private readonly TaiKhoan_BLL taiKhoanBLL;
        private readonly NhanVien_BLL nhanVienBLL;

       

        public frm_NhanVien()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;

            nhanVienBLL = new NhanVien_BLL();
            taiKhoanBLL = new TaiKhoan_BLL();
            LoadNhanVienData();
            SetupEventHandlers();
            txtMaTK.Text = taiKhoanBLL.getNextAccountId();
        }

        private void LoadNhanVienData()
        {
            dgv_NhanVien.DataSource = nhanVienBLL.GetAllNhanVien();
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
                string tenNV = txt_TenNV.Text;
                string email = txt_Email.Text;
                string sdt = txt_SDT.Text;
                string diaChi = txtDiaChi.Text; 
                string maTK = txt_MaTK.Text; 

                if (nhanVienBLL.AddNhanVien(tenNV, email, sdt, diaChi, maTK))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadNhanVienData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
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
                string maNV = txt_MaNV.Text;
                string tenNV = txt_TenNV.Text;
                string email = txt_Email.Text;
                string sdt = txt_SDT.Text;
                string diaChi = txtDiaChi.Text; 
                string maTK = txt_MaTK.Text; 

                if (nhanVienBLL.UpdateNhanVien(maNV, tenNV, email, sdt, diaChi, maTK))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    LoadNhanVienData();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!");
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
                string maNV = txt_MaNV.Text;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nhanVienBLL.DeleteNhanVien(maNV))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadNhanVienData();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
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
            ClearInputFields();
            txt_MaNV.Text = nhanVienBLL.taoMaTuDong();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txt_TimKiem.Text;
                DataTable searchResults = nhanVienBLL.SearchNhanVien(searchTerm);
                dgv_NhanVien.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_NhanVien.SelectedRows[0];
                txt_MaNV.Text = selectedRow.Cells["MaNV"].Value.ToString();
                txt_TenNV.Text = selectedRow.Cells["TenNV"].Value.ToString();
                txt_Email.Text = selectedRow.Cells["Email"].Value.ToString();
                txt_SDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txt_MaTK.Text = selectedRow.Cells["MaTK"].Value.ToString();
                //txt_MaChucVu.Text = selectedRow.Cells["MaChucVu"].Value.ToString();
            }
        }

        private void ClearInputFields()
        {
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_Email.Clear();
            txt_SDT.Clear();
            txt_NgaySinh.Clear();
            txt_GioiTinh.Clear();
            txt_MaTK.Clear();
            txtTenDN.Clear();
            txtMatKhau.Clear();
            txtQuyen.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Add account
                bool accountAdded = taiKhoanBLL.AddTaiKhoan(
                    txtTenDN.Text,
                    txtMatKhau.Text,
                    txtQuyen.Text
                );

                if (accountAdded)
                {
                    MessageBox.Show("Tài khoản đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaTK.Text = taiKhoanBLL.getNextAccountId();
                    txtTenDN.Text = "";
                    txtMatKhau.Text = "";
                    txtQuyen.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể thêm tài khoản. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frm_TaiKhoan : Form
    {
        private TaiKhoan_BLL taiKhoanBLL;
        private NhanVien_BLL nhanVienBLL;
        private List<string> listVaiTro;
        public frm_TaiKhoan()
        {
            InitializeComponent();
            taiKhoanBLL = new TaiKhoan_BLL();
            nhanVienBLL = new NhanVien_BLL();
            listVaiTro = new List<string>();
            listVaiTro.Add("Quản lý");
            listVaiTro.Add("Nhân viên kho");
            listVaiTro.Add("Nhân viên bán hàng");
            txtMaNV.Enabled = false;
            txtMaTK.Enabled = false;
            cbbVaiTro.DataSource = listVaiTro;
            LoadData();
        }

        private void LoadData()
        {
            dgvTaiKhoan.DataSource = taiKhoanBLL.GetAllTaiKhoan();
            dgv_NhanVien.DataSource = nhanVienBLL.GetAllNhanVien();
            dgvTaiKhoan.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dgvTaiKhoan.Columns["vaiTro"].HeaderText = "Vai Trò";
            dgv_NhanVien.Columns["TenNV"].HeaderText = "Tên Nhân Viên"; 
            dgv_NhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";  
            dgv_NhanVien.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgv_NhanVien.Columns["MaTK"].HeaderText = "Mã tài khoản";
            dgv_NhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgv_NhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";


            dgv_NhanVien.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            if (dgvTaiKhoan.Columns.Contains("Xoa"))
            {
                dgvTaiKhoan.Columns["Xoa"].Visible = false;
            }

            if (dgv_NhanVien.Columns.Contains("Xoa"))
            {
                dgv_NhanVien.Columns["Xoa"].Visible = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txtTenDN.Text;
                string matKhau = txtMatKhau.Text;
                string quyen = cbbVaiTro.SelectedValue.ToString();
                string maNV = txtMaNV.Text;
                string matk = txtMaTK.Text;

                // Kiểm tra nếu có chọn nhân viên
                if (!string.IsNullOrEmpty(maNV))
                {
                    // Kiểm tra nhân viên đã có tài khoản chưa
                    string currentMaTK = nhanVienBLL.GetCurrentMaTK(maNV);
                    if (!string.IsNullOrEmpty(currentMaTK))
                    {
                        MessageBox.Show("Nhân viên này đã có tài khoản!", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                bool newMaTK = taiKhoanBLL.AddTaiKhoan(tenDangNhap, matKhau, quyen);
                if (newMaTK)
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!string.IsNullOrEmpty(maNV))
                    {
                        if (nhanVienBLL.UpdateMaTK(maNV, matk))
                        {
                            MessageBox.Show("Cập nhật mã tài khoản cho nhân viên thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật mã tài khoản cho nhân viên thất bại!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maTK = txtMaTK.Text;
                string tenDangNhap = txtTenDN.Text;
                string matKhau = txtMatKhau.Text;
                string quyen = cbbVaiTro.SelectedValue.ToString();
                string maNV = txtMaNV.Text;

                if (!string.IsNullOrEmpty(maNV))
                {
                    // Kiểm tra xem mã tài khoản đã được gán cho nhân viên khác chưa
                    string currentMaTK = nhanVienBLL.GetCurrentMaTK(maNV);

                    

                    // Kiểm tra xem mã tài khoản này đã được gán cho nhân viên khác chưa
                    if (nhanVienBLL.IsMaTKAssigned(maTK))
                    {
                        string assignedToCurrentNV = nhanVienBLL.GetCurrentMaTK(maNV);
                        if (assignedToCurrentNV != maTK)
                        {
                            MessageBox.Show("Mã tài khoản này đã được gán cho nhân viên khác!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                if (taiKhoanBLL.UpdateTaiKhoan(maTK, tenDangNhap, matKhau, quyen))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!string.IsNullOrEmpty(maNV))
                    {
                        if (nhanVienBLL.UpdateMaTK(maNV, maTK))
                        {
                            MessageBox.Show("Cập nhật mã tài khoản cho nhân viên thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật mã tài khoản cho nhân viên thất bại!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maTK = txtMaTK.Text;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (taiKhoanBLL.DeleteTaiKhoan(maTK))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimTK_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txt_searchTK.Text;
                dgvTaiKhoan.DataSource = taiKhoanBLL.SearchTaiKhoan(searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimNV_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txt_TimNV.Text;
                dgv_NhanVien.DataSource = nhanVienBLL.SearchNhanVien(searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtMaTK.Clear();
            txtTenDN.Clear();
            txtMatKhau.Clear();
            cbbVaiTro.SelectedIndex = 0;
            txtMaNV.Clear();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTK.Text = row.Cells["MaTK"].Value.ToString();
                txtTenDN.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                string vaiTro = row.Cells["vaiTro"].Value.ToString();
                // Ensure vaiTro value matches one of the values in listVaiTro
                if (listVaiTro.Contains(vaiTro))
                {
                    cbbVaiTro.SelectedItem = vaiTro;  // Set the selected value
                }
                else
                {
                    MessageBox.Show("Vai trò không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
            }
        }

        private void btn_Moi_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFields();
                string newMaTK = taiKhoanBLL.getNextAccountId();
                txtMaTK.Text = newMaTK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
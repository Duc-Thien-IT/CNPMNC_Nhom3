using System;
using System.Windows.Forms;
using System.Data;
using BLL;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace GUI
{
    public partial class frm_NhanVien : Form
    {

        private readonly TaiKhoan_BLL taiKhoanBLL;
        private readonly NhanVien_BLL nhanVienBLL;
        private List<string> listGioiTinh;


        public frm_NhanVien()
        {
            InitializeComponent();
         
            txt_MaNV.Enabled = false;
            txt_MaTK.Enabled = false;
            nhanVienBLL = new NhanVien_BLL();
            taiKhoanBLL = new TaiKhoan_BLL();
            listGioiTinh = new List<string>();
            listGioiTinh.Add("Nam");
            listGioiTinh.Add("Nữ");
            cbbGioiTinh.DataSource = listGioiTinh;
            setUpDTP();
            LoadNhanVienData();
            SetupEventHandlers();
           
        }
        private void setUpDTP()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            // Định dạng ngày giờ cho DateTimePicker
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        }
        private void LoadNhanVienData()
        {
            dgv_NhanVien.DataSource = nhanVienBLL.GetAllNhanVien();
            dgv_NhanVien.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
            dgv_NhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgv_NhanVien.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgv_NhanVien.Columns["MaTK"].HeaderText = "Mã tài khoản";
            dgv_NhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgv_NhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";


            dgv_NhanVien.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            if (dgv_NhanVien.Columns.Contains("Xoa"))
            {
                dgv_NhanVien.Columns["Xoa"].Visible = false;
            }
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
                // Lấy giá trị từ các ô nhập liệu
                string tenNV = txt_TenNV.Text;
                string email = txt_Email.Text;
                string sdt = txt_SDT.Text;
                string diaChi = txtDiaChi.Text;
                
                string gioiTinh = cbbGioiTinh.SelectedValue.ToString();
                DateTime ngaySinh = dtpNgaySinh.Value;
                // Kiểm tra tên nhân viên
                string tenNVError = nhanVienBLL.CheckTenNV(tenNV);
                if (!string.IsNullOrEmpty(tenNVError))
                {
                    MessageBox.Show(tenNVError + "\nVui lòng nhập tên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TenNV.Focus(); // Chuyển focus về ô Tên nhân viên
                    return;
                }

                // Kiểm tra email
                string emailError = nhanVienBLL.CheckEmail(email);
                if (!string.IsNullOrEmpty(emailError))
                {
                    MessageBox.Show(emailError + "\nVui lòng nhập email hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Email.Focus(); // Chuyển focus về ô Email
                    return;
                }

                // Kiểm tra số điện thoại
                string sdtError = nhanVienBLL.CheckSDT(sdt);
                if (!string.IsNullOrEmpty(sdtError))
                {
                    MessageBox.Show(sdtError + "\nVui lòng nhập số điện thoại hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_SDT.Focus(); // Chuyển focus về ô Số điện thoại
                    return;
                }


                if (nhanVienBLL.AddNhanVien( tenNV, email, sdt, diaChi, gioiTinh, ngaySinh))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVienData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string gioiTinh = cbbGioiTinh.SelectedValue.ToString();
                DateTime ngaySinh = dtpNgaySinh.Value;

                if (nhanVienBLL.UpdateNhanVien(maNV, tenNV, email, sdt, diaChi, maTK,gioiTinh,ngaySinh))
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

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                // Kiểm tra nếu người dùng chọn Yes
                if (result == DialogResult.Yes)
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
            txt_MaNV.Text = nhanVienBLL.TaoMaTuDong();
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
                cbbGioiTinh.SelectedItem = selectedRow.Cells["GioiTinh"].Value.ToString();
                if (DateTime.TryParse(selectedRow.Cells["NgaySinh"].Value.ToString(), out DateTime ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh;
                }
                else
                {
                    dtpNgaySinh.Value = DateTime.Now; // Set a default value if parsing fails
                }
            }
        }

        private void ClearInputFields()
        {
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_Email.Clear();
            txt_SDT.Clear();
            txt_MaTK.Clear();
           
        }

       

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txt_TimKiem.Text.Trim();
                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable searchResults = nhanVienBLL.SearchNhanVien(searchTerm);

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
    }
}


using System;
using System.Windows.Forms;
using BLL;
using System.Data;
using System.Globalization;
using System.Threading;

namespace GUI
{
    public partial class frm_KhachHang : Form
    {
        private readonly KhachHang_BLL khachHangBLL;
        private readonly NhanVien_BLL nhanVien_BLL;
        public frm_KhachHang()
        {
            InitializeComponent();
            nhanVien_BLL = new NhanVien_BLL();
            khachHangBLL = new KhachHang_BLL();
            LoadKhachHangData();
            SetupEventHandlers();
            txt_MaKH.Enabled = false;
            setUpDTP();
        }
        private void TaoMaKH()
        {
            string maKH=khachHangBLL.GetNextCustomerId();
            txt_MaKH.Text = maKH;
        }
        private void setUpDTP()
        {
           
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            
            
        }
        private void LoadKhachHangData()
        {
            dgv_NhanVien.DataSource = khachHangBLL.GetAllKhachHang();

          
            if (dgv_NhanVien.Columns.Contains("MaKH"))
                dgv_NhanVien.Columns["MaKH"].HeaderText = "Mã Khách Hàng";

            if (dgv_NhanVien.Columns.Contains("TenKH"))
                dgv_NhanVien.Columns["TenKH"].HeaderText = "Tên Khách Hàng";

        

            if (dgv_NhanVien.Columns.Contains("SDT"))
                dgv_NhanVien.Columns["SDT"].HeaderText = "Số Điện Thoại";

            if (dgv_NhanVien.Columns.Contains("DiaChi"))
                dgv_NhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";

          
            if (dgv_NhanVien.Columns.Contains("Xoa"))
                dgv_NhanVien.Columns["Xoa"].Visible = false;
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
        private bool CheckAge(DateTime ngaySinh)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - ngaySinh.Year;

            if (ngaySinh.Date > today.AddYears(-age))
            {
                age--;
            }

            return age >= 18;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txt_MaKH.Text;
                string tenKH = txt_TenNV.Text;
              
                string sdt = txt_SDT.Text;
                string diaChi = txt_DiaChi.Text;
              
                if(tenKH.Length==0)
                {
                    MessageBox.Show("Không được để trống tên khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TenNV.Focus();
                    return;
                }
               

                if (diaChi.Length == 0)
                {
                    MessageBox.Show("Không được để trống địa chỉ khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_DiaChi.Focus();
                    return;
                }
                if (sdt.Length == 0)
                {
                    MessageBox.Show("Không được để trống số điện thoại khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_SDT.Focus();
                    return;
                }
                if(khachHangBLL.IsExistPhoneNumber(sdt))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_SDT.Focus();
                    return;
                }    


                // Kiểm tra số điện thoại
                string sdtError = nhanVien_BLL.CheckSDT(sdt);
                if (!string.IsNullOrEmpty(sdtError))
                {
                    MessageBox.Show(sdtError + "\nVui lòng nhập số điện thoại hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_SDT.Focus(); // Chuyển focus về ô Số điện thoại
                    return;
                }
                if (khachHangBLL.AddKhachHang(maKH, tenKH,  sdt, diaChi))
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
                string maKH = txt_MaKH.Text;
                string tenKH = txt_TenNV.Text;
               
                string sdt = txt_SDT.Text;
                string diaChi = txt_DiaChi.Text;


                if (tenKH.Length == 0)
                {
                    MessageBox.Show("Không được để trống tên khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TenNV.Focus();
                    return;
                }


                if (diaChi.Length == 0)
                {
                    MessageBox.Show("Không được để trống địa chỉ khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_DiaChi.Focus();
                    return;
                }
                if (sdt.Length == 0)
                {
                    MessageBox.Show("Không được để trống số điện thoại khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_SDT.Focus();
                    return;
                }


                // Kiểm tra số điện thoại
                string sdtError = nhanVien_BLL.CheckSDT(sdt);
                if (!string.IsNullOrEmpty(sdtError))
                {
                    MessageBox.Show(sdtError + "\nVui lòng nhập số điện thoại hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_SDT.Focus(); // Chuyển focus về ô Số điện thoại
                    return;
                }
                if (khachHangBLL.IsExistPhoneNumber(sdt))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_SDT.Focus();
                    return;
                }
                if (khachHangBLL.UpdateKhachHang(maKH, tenKH, sdt, diaChi))
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
                string maKH = txt_MaKH.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            TaoMaKH();
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
                txt_MaKH.Text = row.Cells["MaKH"].Value.ToString();
                txt_TenNV.Text = row.Cells["TenKH"].Value.ToString();
               
                txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString(); 
            }
        }

        private void ClearInputs()
        {
            txt_MaKH.Clear();
            txt_TenNV.Clear();
           
            txt_SDT.Clear();
            txt_DiaChi.Clear();
            txt_TimKiem.Clear();
        }

   
    }
}
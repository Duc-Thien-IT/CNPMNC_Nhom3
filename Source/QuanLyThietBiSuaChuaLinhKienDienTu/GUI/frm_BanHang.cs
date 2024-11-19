using BLL;
using DAL;
using DTO;
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
    public partial class frm_BanHang : Form
    {
        private readonly SanPham_BLL spBLL;
        private readonly BanHang_BLL bhBLL;
        public frm_BanHang()
        {
            InitializeComponent();
            spBLL = new SanPham_BLL();
            bhBLL = new BanHang_BLL();
            LoadSanPham();
            LoadKhachHang();
            LoadDanhSachHoaDon();
            
            // Kiểm tra nếu dgvDanhSachLinhKienDaChon chưa có cột nào
            if (dgvDanhSachLinhKienDaChon.Columns.Count == 0)
            {
                dgvDanhSachLinhKienDaChon.Columns.Add("MaSP", "Mã Sản Phẩm");
                dgvDanhSachLinhKienDaChon.Columns.Add("TenSP", "Tên Sản Phẩm");
                dgvDanhSachLinhKienDaChon.Columns.Add("Gia", "Giá");
                dgvDanhSachLinhKienDaChon.Columns["Gia"].DefaultCellStyle.Format = "N0"; // Định dạng hiển thị số tiền
                dgvDanhSachLinhKienDaChon.Columns.Add("SoLuong", "Số Lượng");
                dgvDanhSachLinhKienDaChon.Columns.Add("ThoiGianBaoHanh", "Thời Gian Bảo Hành");
                dgvDanhSachLinhKienDaChon.Columns["MaSP"].Visible = false;
            }
            AutoResizeDataGridView(dgvSanPham);
            AutoResizeDataGridView(dgvDanhSachLinhKienDaChon);
        }
        public void LoadDanhSachHoaDon()
        {
            DataTable danhSachHoaDon = bhBLL.LoadDanhSachHoaDon();
            if (danhSachHoaDon != null)
            {
                cboDanhSachHoaDon.DataSource = danhSachHoaDon;
                cboDanhSachHoaDon.DisplayMember = "MaHoaDon"; // Cột hiển thị
                cboDanhSachHoaDon.ValueMember = "MaHoaDon";   // Giá trị thực tế
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách hóa đơn.");
            }
        }
        public void AutoResizeDataGridView(DataGridView dgv)
        {
            // Set the AutoSizeColumnsMode to Fill to have columns adjust to fill the entire width
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Additionally, you can specify minimum widths or other settings for individual columns if needed
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.MinimumWidth = 50; // Set a minimum width as an example, adjust as needed
            }
        }
        private void LoadKhachHang()
        {
            // Lấy danh sách khách hàng từ DAL
            List<KhachHangDTO> danhSachKhachHang = bhBLL.LayDanhSachKhachHang();

            // Đổ dữ liệu vào ComboBox
            cboKhachHang.DataSource = danhSachKhachHang;
            cboKhachHang.DisplayMember = "TenKH";  // Hiển thị tên khách hàng
            cboKhachHang.ValueMember = "MaKH";    // Lưu mã khách hàng
        }
        private void LoadSanPham()
        {
            try
            {
                DataTable dtSanPham = spBLL.GetAllSanPham();

                dgvSanPham.DataSource = dtSanPham;
                dgvSanPham.Columns["Gia"].DefaultCellStyle.Format = "N0";
                dgvSanPham.Columns["MaSP"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                // Lấy thông tin món ăn từ dòng đã chọn
                string malinhkien = dgvSanPham.SelectedRows[0].Cells["MaSP"].Value.ToString();
                string tenLinhKien = dgvSanPham.SelectedRows[0].Cells["TenSP"].Value.ToString();
                float gialinhkien = Convert.ToSingle(dgvSanPham.SelectedRows[0].Cells["Gia"].Value);
                int soLuongCoTheBan = Convert.ToInt32(dgvSanPham.SelectedRows[0].Cells["SoLuongTon"].Value);
                int thoigianbaohanh = Convert.ToInt32(dgvSanPham.SelectedRows[0].Cells["ThoiGianBaoHanh"].Value);

                // Lấy số lượng từ txtSoLuong
                if (int.TryParse(txtSoLuong.Text, out int soLuong))
                {
                    // Kiểm tra số lượng có lớn hơn số lượng có thể bán không
                    if (soLuong > soLuongCoTheBan)
                    {
                        MessageBox.Show("Số lượng không thể lớn hơn số lượng có thể bán.");
                        return;
                    }
                    if(soLuong == 0)
                    {
                        MessageBox.Show("hãy ghi số lượng > 0");
                        return;
                    }
                        
                    // Kiểm tra xem món ăn đã tồn tại trong dgvDanhSachMonChon hay chưa
                    bool linhkiendatontai = false;
                    foreach (DataGridViewRow row in dgvDanhSachLinhKienDaChon.Rows)
                    {
                        // Kiểm tra xem ô có giá trị null hay không
                        if (row.Cells["TenSP"].Value != null && row.Cells["TenSP"].Value.ToString() == tenLinhKien)
                        {
                            // Nếu đã tồn tại, cộng thêm số lượng
                            int soLuongHienTai = Convert.ToInt32(row.Cells["SoLuong"].Value);
                            if (soLuongHienTai + soLuong > soLuongCoTheBan)
                            {
                                MessageBox.Show("Số lượng không thể lớn hơn số lượng có thể bán.");
                                return;
                            }
                            row.Cells["SoLuong"].Value = soLuongHienTai + soLuong;
                            linhkiendatontai = true;
                            break;
                        }
                    }

                    // Nếu món ăn chưa tồn tại, thêm mới
                    if (!linhkiendatontai)
                    {
                        int index = dgvDanhSachLinhKienDaChon.Rows.Add();
                        dgvDanhSachLinhKienDaChon.Rows[index].Cells["MaSP"].Value = malinhkien;
                        dgvDanhSachLinhKienDaChon.Rows[index].Cells["TenSP"].Value = tenLinhKien;
                        dgvDanhSachLinhKienDaChon.Rows[index].Cells["Gia"].Value = gialinhkien;
                        dgvDanhSachLinhKienDaChon.Rows[index].Cells["ThoiGianBaoHanh"].Value = thoigianbaohanh;
                        dgvDanhSachLinhKienDaChon.Rows[index].Cells["SoLuong"].Value = soLuong; // Thêm số lượng
                    }
                    // Cập nhật tổng tiền
                    UpdateTotalMoney();
                    txtSoLuong.Clear();
                    txtSoLuong.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn để thêm.");
            }
        }
        private void UpdateTotalMoney()
        {
            decimal totalMoney = 0;

            foreach (DataGridViewRow row in dgvDanhSachLinhKienDaChon.Rows)
            {
                if (row.Cells["Gia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Gia"].Value);
                    int quantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    totalMoney += price * quantity;
                }
            }
            lblTongCong.Text = totalMoney.ToString("N0"); // Cập nhật lblTotalMoney
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (dgvDanhSachLinhKienDaChon.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = dgvDanhSachLinhKienDaChon.SelectedRows[0];

                // Xóa dòng đã chọn
                dgvDanhSachLinhKienDaChon.Rows.Remove(selectedRow);

                // Hiển thị thông báo thành công
                MessageBox.Show("Đã xóa linh kiện khỏi danh sách.");
                UpdateTotalMoney();
            }
            else
            {
                // Nếu không có dòng nào được chọn, hiển thị thông báo
                MessageBox.Show("Vui lòng chọn linh kiện để xóa.");
            }
        }

        private void txtTimKiemSanPham_TextChanged(object sender, EventArgs e)
        {
            string tenLinhKien = txtTimKiemSanPham.Text.Trim();

            // Kiểm tra nếu tên sản phẩm trống thì không tìm kiếm
            if (string.IsNullOrEmpty(tenLinhKien))
            {
                LoadSanPham();
                return;
            }

            // Gọi phương thức BLL để lấy danh sách sản phẩm
            DataTable dtSanPham = bhBLL.TimKiemSanPhamTheoTen(tenLinhKien);

            // Kiểm tra nếu có dữ liệu trả về
            if (dtSanPham.Rows.Count > 0)
            {
                dgvSanPham.DataSource = dtSanPham;

                // Đặt lại các thuộc tính hiển thị cho DataGridView nếu cần
                dgvSanPham.Columns["Gia"].DefaultCellStyle.Format = "N0"; // Định dạng giá với dấu phân cách hàng nghìn
                dgvSanPham.Columns["MaSP"].Visible = false; // Ẩn cột mã sản phẩm
            }
            else
            {
                LoadSanPham(); // Nếu không có sản phẩm nào, xóa dữ liệu
            }
        }
        private void TimKiemLinhKien(string tuKhoa)
        {
            // Duyệt qua tất cả các dòng trong DataGridView
            foreach (DataGridViewRow row in dgvDanhSachLinhKienDaChon.Rows)
            {
                // Kiểm tra nếu tên linh kiện chứa từ khóa tìm kiếm (case-insensitive)
                bool isMatch = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(tuKhoa.ToLower()))
                    {
                        isMatch = true;
                        break;  // Nếu tìm thấy giá trị khớp, không cần kiểm tra các cột còn lại
                    }
                }

                // Ẩn hoặc hiển thị dòng tùy thuộc vào kết quả tìm kiếm
                row.Visible = isMatch;
            }
        }

        private void txttimKiemSanPhamDaChon_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txttimKiemSanPhamDaChon.Text.Trim();  
            TimKiemLinhKien(tuKhoa);  
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            // Tạo mã hóa đơn mới
            string maHoaDonMoi = bhBLL.TaoMaHoaDonMoi();
            // Lấy dữ liệu từ form
            string maHoaDon = maHoaDonMoi;
            DateTime ngayLap = DateTime.Now;
            decimal thanhTien = Convert.ToDecimal(lblTongCong.Text.Trim());
            string phuongThucThanhToan = null;

            if (cboPhuongThucThanhToan.SelectedItem != null)
            {
                phuongThucThanhToan = cboPhuongThucThanhToan.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán.");
                return;
            }

            string maNV = "NV001";
            string maKH;
            if (cboKhachHang.SelectedItem != null)
            {
                // Ép kiểu đối tượng được chọn thành KhachHangDTO
                var selectedCustomer = (KhachHangDTO)cboKhachHang.SelectedItem;
                maKH = selectedCustomer.MaKH; // Mã khách hàng
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            // Lưu hóa đơn
            bool hoaDonLuuThanhCong = bhBLL.LuuHoaDon(maHoaDon, ngayLap, thanhTien, phuongThucThanhToan, maNV, maKH);

            if (hoaDonLuuThanhCong)
            {
                // Kiểm tra xem có sản phẩm nào trong dgvDanhSachLinhKienDaChon không
                if (dgvDanhSachLinhKienDaChon.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có sản phẩm nào được chọn trong giỏ hàng.");
                    return;  // Nếu không có sản phẩm, dừng thực hiện
                }

                // Duyệt qua dgvDanhSachLinhKienDaChon và lưu chi tiết hóa đơn
                foreach (DataGridViewRow row in dgvDanhSachLinhKienDaChon.Rows)
                {
                    // Lấy thông tin từ từng dòng trong DataGridView
                    string maSP = row.Cells["MaSP"].Value.ToString(); // Giả sử bạn có cột MaSP
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    decimal tongTien = Convert.ToDecimal(row.Cells["Gia"].Value)*soLuong;

                    // Lưu chi tiết hóa đơn
                    bool chiTietLuuThanhCong = bhBLL.LuuChiTietHoaDon(maSP, maHoaDon, soLuong, tongTien);
                    if (!chiTietLuuThanhCong)
                    {
                        MessageBox.Show("Lưu chi tiết hóa đơn thất bại!");
                        return;
                    }

                    // Cập nhật số lượng sản phẩm trong kho
                    bool capNhatKhoThanhCong = bhBLL.CapNhatSoLuongKho(maSP, soLuong);
                    if (!capNhatKhoThanhCong)
                    {
                        MessageBox.Show("Cập nhật số lượng kho thất bại!");
                        return;
                    }
                }
                MessageBox.Show("Hóa đơn "+ maHoaDon + " và chi tiết hóa đơn đã được lưu thành công!");
                LoadSanPham();
                // Xóa tất cả dữ liệu trong DataGridView
                dgvDanhSachLinhKienDaChon.Rows.Clear();
                LoadDanhSachHoaDon();
            }
            else
            {
                MessageBox.Show("Lưu hóa đơn thất bại!");
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string maHoaDon = cboDanhSachHoaDon.SelectedValue.ToString();
            DataSet dulieu = LoadInvoiceReport(maHoaDon);
            frm_HoaDon frm = new frm_HoaDon(dulieu);
            frm.ShowDialog();
        }
        private DataSet LoadInvoiceReport(string maHoaDon)
        {
           
            CombinedInvoiceDTO dulieu = new CombinedInvoiceDTO();

            dulieu = bhBLL.GetInvoiceDetails(maHoaDon);

            // Tạo DataTable cho chi tiết hóa đơn
            // Tạo DataTable cho thông tin hóa đơn
            DataTable invoiceDetails = new DataTable();
            DataTable invoiceInfo = new DataTable();

            if (dulieu != null && dulieu.InvoiceDetails != null && dulieu.Items.Count > 0)
            {

                invoiceDetails.Columns.Add("TenLinhKien", typeof(string));
                invoiceDetails.Columns.Add("SoLuong", typeof(int));
                invoiceDetails.Columns.Add("Gia", typeof(decimal));
                invoiceDetails.Columns.Add("Tong", typeof(decimal));


                invoiceInfo.Columns.Add("MaHoaDon", typeof(string));
                invoiceInfo.Columns.Add("ThanhTien", typeof(decimal));
                invoiceInfo.Columns.Add("NgayThanhToan", typeof(DateTime));
                invoiceInfo.Columns.Add("TenKhachHang", typeof(string));
                invoiceInfo.Columns.Add("DiaChi", typeof(string));
                invoiceInfo.Columns.Add("SDT", typeof(string));
                invoiceInfo.Columns.Add("QRCode", typeof(byte[]));
                foreach (var item in dulieu.Items)
                {
                    invoiceDetails.Rows.Add(item.TenLinhKien, item.SoLuong, item.Gia.ToString("N0"), item.Tong.ToString("N0"));
                }
                
                        invoiceInfo.Rows.Add(
                                   dulieu.InvoiceDetails.MaHoaDon,
                                   dulieu.InvoiceDetails.ThanhTien.ToString("N0"),
                                   DateTime.Now,
                                   dulieu.InvoiceDetails.TenKhachHang,
                                   dulieu.InvoiceDetails.DiaChi,
                                   dulieu.InvoiceDetails.SDT
                               );
                   
                // Tạo DataSet và thêm các DataTable vào
                DataSet invoiceDataSet = new DataSet();
                invoiceDataSet.Tables.Add(invoiceDetails);   // Thêm chi tiết hóa đơn
                invoiceDataSet.Tables.Add(invoiceInfo);      // Thêm thông tin hóa đơn
                return invoiceDataSet;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu hóa đơn");
                return null;
            }
            // Thêm dữ liệu vào DataTable
            //invoiceDetails.Rows.Add("Fried Chicken", 2, 150.00, 300.00);
            //invoiceDetails.Rows.Add("Burger", 1, 50.00, 50.00);

            // Thêm dữ liệu vào DataTable thông tin hóa đơn
            //invoiceInfo.Rows.Add("John Doe", "Cash", "HD001", 350.00, 35.00, 0.00, 10, 375.00, 400.00, 25.00, 5, DateTime.Now.ToString());


        }
    }
}

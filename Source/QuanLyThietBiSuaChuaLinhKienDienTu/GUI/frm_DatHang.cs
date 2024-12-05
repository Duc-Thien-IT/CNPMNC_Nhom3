using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frm_DatHang : Form
    {
        private readonly DatHang_BLL dhBLL;
        List<ChiTietPhieuDat> lsCTDH = new List<ChiTietPhieuDat>();
        public frm_DatHang()
        {
            InitializeComponent();
            dhBLL = new DatHang_BLL();
            CultureInfo culture = new CultureInfo("vi-VN");
            Application.CurrentCulture = culture;
            dateNgayBatDau.Format = DateTimePickerFormat.Custom;
            dateNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dateNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dateNgayKetThuc.CustomFormat = "dd/MM/yyyy";
        }

        private void frm_DatHang_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1232, 765);
            try
            {
                DataTable dtSP = dhBLL.GetAllSanPham(tb_TimKiemSP.Text);
                dgvSanPham.DataSource = dtSP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                DataTable dtNCC = dhBLL.GetAllNhaCungCap();
                cbNhaCungCap.DataSource = dtNCC;
                cbNhaCungCap.DisplayMember= "TenNCC";
                cbNhaCungCap.ValueMember= "MaNCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadPhieuDat();
        }

        private void clearTebox()
        {
            tb_MaPhieuDat.Text = string.Empty;
            txt_ThanhTien.Text = string.Empty;
        }

        private void loadPhieuDat()
        {
            dgvPhieuDat.DataSource = null;
            dgvChiTietPhieuDat.DataSource = null;
            try
            {
                DataTable dtPhieuDat = dhBLL.GetAllPhieuDat();
                dgvPhieuDat.DataSource = dtPhieuDat;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh phiếu Đạt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   

        private void dgvPhieuDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexSelect = e.RowIndex;
                DataGridViewRow data = dgvPhieuDat.Rows[indexSelect];
                tb_MaPhieuDat.Text = data.Cells[0].Value.ToString();
                txt_ThanhTien.Text = data.Cells[2].Value != null ? data.Cells[2].Value.ToString() : string.Empty;
                tb_MaPhieuDat.ReadOnly = true;
                txt_ThanhTien.ReadOnly = true;
                try
                {
                    DataTable dtChiTietPhieuDat = dhBLL.GetAllChiTietPhieuDat(tb_MaPhieuDat.Text);
                    dgvChiTietPhieuDat.DataSource = dtChiTietPhieuDat;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh chi tiết phiếu đặt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void tb_TimKiemSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSP = dhBLL.GetAllSanPham(tb_TimKiemSP.Text);
                if (dtSP != null)
                {
                    dgvSanPham.DataSource = dtSP;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPD = dhBLL.CreateMaPhieuDat();
                tb_MaPhieuDat.Text = MaPD;
                txt_ThanhTien.Text = "0";
                tb_MaPhieuDat.ReadOnly = true;
                txt_ThanhTien.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuPhieuDat_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPD = tb_MaPhieuDat.Text;
                if (string.IsNullOrEmpty(MaPD))
                {
                    MessageBox.Show("Mã Phiếu Đặt Không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool result = dhBLL.AddPhieuDat(tb_MaPhieuDat.Text,cbNhaCungCap.SelectedValue.ToString(),"NV001");

                if (result)
                {
                    MessageBox.Show("Thêm phiếu đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPhieuDat();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu đặt thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_HuyPhieuDat_Click(object sender, EventArgs e)
        {
            try
            {
                dhBLL.DeletePhieuDat(tb_MaPhieuDat.Text);
                MessageBox.Show("Xóa Phiếu Nhập Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadPhieuDat();
                clearTebox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Phiếu Nhập Thất Bại!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LuuChiTietPhieuDat_Click(object sender, EventArgs e)
        {
            string mapd = string.Empty, masp = string.Empty;
            int soluong = 0;
            decimal gia = 0;
            decimal TongTien = 0;

            try
            {
                foreach (DataGridViewRow row in dgvChiTietPhieuDat.Rows)
                {
                    // Kiểm tra dòng không phải là dòng trống cuối cùng
                    if (!row.IsNewRow)
                    {
                        // Kiểm tra và gán giá trị từ ô
                        if (row.Cells[0].Value != null && row.Cells[1].Value != null &&
                            row.Cells[3].Value != null && row.Cells[4].Value != null)
                        {
                            mapd = row.Cells[0].Value.ToString();
                            masp = row.Cells[1].Value.ToString();

                            if (int.TryParse(row.Cells[3].Value.ToString(), out int parsedSoLuong))
                            {
                                soluong = parsedSoLuong;
                            }
                            else
                            {
                                MessageBox.Show($"Dữ liệu không hợp lệ ở cột số lượng (hàng {row.Index + 1})!",
                                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                continue; // Bỏ qua dòng này
                            }

                            if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal parsedGia))
                            {
                                gia = parsedGia;
                            }
                            else
                            {
                                MessageBox.Show($"Dữ liệu không hợp lệ ở cột giá (hàng {row.Index + 1})!",
                                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                continue; // Bỏ qua dòng này
                            }

                            // Thêm chi tiết phiếu đặt
                            dhBLL.AddChiTietPhieuDat(mapd, masp, soluong, gia);
                            TongTien += soluong * gia;
                        }
                        else
                        {
                            MessageBox.Show($"Dòng {row.Index + 1} chứa dữ liệu không đầy đủ. Vui lòng kiểm tra lại!",
                                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // Cập nhật tổng tiền và thông báo kết quả
                dhBLL.UpdaetThanhTienPhieuDat(tb_MaPhieuDat.Text, TongTien);
                MessageBox.Show("Thêm chi tiết phiếu đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu và reset
                loadPhieuDat();
                lsCTDH.Clear();
                txt_ThanhTien.Text = string.Empty;
                tb_MaPhieuDat.Text= string.Empty;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm chi tiết phiếu đặt thất bại! " + ex.Message,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal TongThanhTien;
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaPD = tb_MaPhieuDat.Text;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                ChiTietPhieuDat ct = new ChiTietPhieuDat();
                bool isChecked = row.Cells[0].Value != null && (bool)row.Cells[0].Value;
                if (isChecked)
                {
                    ct.MaPhieuDat = MaPD;
                    ct.MaSP = row.Cells[1].Value.ToString();
                    ct.TenSP = row.Cells[2].Value.ToString();
                    ct.SoLuongDat = 1;
                    ct.DonGia = Decimal.Parse(row.Cells[3].Value.ToString());
                    ct.TongTien = ct.DonGia * ct.SoLuongDat;
                    TongThanhTien += ct.TongTien;
                    var ctpd = lsCTDH.FirstOrDefault(t => t.MaSP == ct.MaSP);
                    if (ctpd != null)
                    {
                        MessageBox.Show("Sản phẩm có mã " + ct.MaSP + " đã tồn tại trong chi tiết phiếu đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lsCTDH.Add(ct);
                    }
                    row.Cells[0].Value = false;
                }
            }
            txt_ThanhTien.Text = TongThanhTien.ToString();
            loadChiTietSanPham(lsCTDH);
        }

        public DataTable ConvertListToDataTable(List<ChiTietPhieuDat> listCtpd)
        {
            DataTable tb = new DataTable();

            // 1. Tạo cấu trúc cột cho DataTable
            tb.Columns.Add("MaPhieuDat", typeof(string));
            tb.Columns.Add("MaSP", typeof(string));
            tb.Columns.Add("TenSP", typeof(string));
            tb.Columns.Add("SoluongDat", typeof(int));
            tb.Columns.Add("DonGia", typeof(decimal));
            tb.Columns.Add("TongTien", typeof(decimal));

            // 2. Duyệt qua danh sách và thêm dữ liệu vào DataTable
            foreach (var item in listCtpd)
            {
                tb.Rows.Add(item.MaPhieuDat, item.MaSP, item.TenSP, item.SoLuongDat, item.DonGia, item.TongTien);
            }

            return tb;
        }

        private void loadChiTietSanPham(List<ChiTietPhieuDat> listCtpd)
        {
            try
            {
                DataTable tbCTSP = ConvertListToDataTable(listCtpd);
                dgvChiTietPhieuDat.DataSource = tbCTSP;

            }
            catch(Exception ex)
            {
                MessageBox.Show("thất bại! : " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //ThanhTien();
            //tb_ThanhTien.Text = thanhTien.ToString();
        }
        private decimal TinhTongTien()
        {
            TongThanhTien = 0;
            foreach (DataGridViewRow row in dgvChiTietPhieuDat.Rows)
            {
                // Kiểm tra nếu dòng không phải dòng mới (empty row)
                if (!row.IsNewRow)
                {
                    // Lấy giá trị của ô giá và số lượng với kiểm tra null
                    decimal gia = row.Cells[3].Value != null ? Convert.ToDecimal(row.Cells[3].Value) : 0;  // Cột thứ 4 (Giá)
                    int soLuong = row.Cells[4].Value != null ? Convert.ToInt32(row.Cells[4].Value) : 0;    // Cột thứ 5 (Số lượng)

                    // Tính tổng tiền
                    TongThanhTien += gia * soLuong;
                }
            }
            return TongThanhTien;
        }


        private void dgvChiTietPhieuDat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int SoLuong;
            decimal Gia, TongTien;
            if (e.RowIndex >= 0 && dgvChiTietPhieuDat.Columns[e.ColumnIndex].Name == "SoluongDat")
            {
                var row = dgvChiTietPhieuDat.Rows[e.RowIndex];
                SoLuong = int.Parse(row.Cells["SoluongDat"].Value.ToString());
                Gia = Decimal.Parse(row.Cells["DonGia"].Value.ToString());
                TongTien = SoLuong * Gia;
                row.Cells["TongTien"].Value = TongTien;
                txt_ThanhTien.Text = TinhTongTien().ToString();
                var ctpd = lsCTDH.FirstOrDefault(ct => ct.MaSP == IdSanPham);
                if (ctpd != null)
                {
                    ctpd.SoLuongDat = SoLuong;
                    ctpd.TongTien = TongTien;
                }
            }
            if (e.RowIndex >= 0 && dgvChiTietPhieuDat.Columns[e.ColumnIndex].Name == "DonGia")
            {
                var row = dgvChiTietPhieuDat.Rows[e.RowIndex];
                SoLuong = int.Parse(row.Cells["SoluongDat"].Value.ToString());
                Gia = Decimal.Parse(row.Cells["DonGia"].Value.ToString());
                TongTien = SoLuong * Gia;
                row.Cells["TongTien"].Value = TongTien;
                txt_ThanhTien.Text = TinhTongTien().ToString();
                var ctpd = lsCTDH.FirstOrDefault(ct => ct.MaSP == IdSanPham);
                if (ctpd != null)
                {
                    ctpd.SoLuongDat = SoLuong;
                    ctpd.TongTien = TongTien;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateNgayBatDau.Value.Date;
            DateTime endDate = dateNgayKetThuc.Value.Date;
            try
            {
                DataTable dtPD = dhBLL.GetAllPhieuDatTheoNgay(startDate, endDate);
                dgvPhieuDat.DataSource = dtPD;
                
            }
            catch(Exception ex)
            {

            }
        }

        private void btn_XoaChiTietSanPham_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa sản phẩm với ID: " + IdSanPham + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lsCTDH.RemoveAll(ctpd => ctpd.MaSP == IdSanPham);
                loadChiTietSanPham(lsCTDH);
                decimal tongtien = TinhTongTien();
                txt_ThanhTien.Text = tongtien.ToString();
                MessageBox.Show($"Sản phẩm với ID: {IdSanPham} đã được xóa khỏi danh sách chi tiết phiếu nhập .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private string IdSanPham;

        private void dgvChiTietPhieuDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexSelect = e.RowIndex;
                DataGridViewRow data = dgvChiTietPhieuDat.Rows[indexSelect];
                IdSanPham = data.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
    }
}

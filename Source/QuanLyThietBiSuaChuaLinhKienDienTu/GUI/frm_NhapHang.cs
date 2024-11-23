using System;
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
    public partial class frm_NhapHang : Form
    {
        private readonly NhapHang_BLL nhBLL;
        List<ChiTietPhieuGiao> lsCTPG = new List<ChiTietPhieuGiao>();
        public frm_NhapHang()
        {
            InitializeComponent();
            nhBLL = new NhapHang_BLL();
            CultureInfo culture = new CultureInfo("vi-VN");
            Application.CurrentCulture = culture;
            dateNgayBatDau.Format = DateTimePickerFormat.Custom;
            dateNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dateNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dateNgayKetThuc.CustomFormat = "dd/MM/yyyy";
        }

        private void frm_NhapHang_Load(object sender, EventArgs e)
        {

            LoadSanPham();
            loadPhieuGiao();


        }

        private void LoadSanPham()
        {
            try
            {
                DataTable dtSP = nhBLL.GetAllSanPham(tb_TimKiemSP.Text);
                dgvSanPham.DataSource = dtSP;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadPhieuGiao()
        {
            try
            {
                DataTable dtPhieuGiao = nhBLL.GetAllPhieuGiao(tb_MaPhieuDat.Text);

                dgvPhieuNhap.DataSource = dtPhieuGiao;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh phiếu giao: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexSelect = e.RowIndex;
                DataGridViewRow data = dgvPhieuNhap.Rows[indexSelect];
                tb_MaPN.Text = data.Cells[0].Value.ToString();
                tb_MaPhieuDat.Text = data.Cells[1].Value.ToString();
                tb_ThanhTien.Text = data.Cells[4].Value != null ? data.Cells[4].Value.ToString() : string.Empty;
                if (data.Cells[3].Value != null)
                {
                    int result;
                    if (int.TryParse(data.Cells[3].Value.ToString(), out result))
                    {
                        number_LanGiao.Value = result;
                    }
                    else
                    {
                        number_LanGiao.Value = 1;
                    }
                }
                else
                {
                    number_LanGiao.Value = 1;
                }
                tb_MaPN.ReadOnly = true;
                tb_ThanhTien.ReadOnly = true;
                //tb_MaPhieuDat.ReadOnly = true;
                number_LanGiao.ReadOnly = true;


            
                try
                {
                    DataTable dtChiTietPhieuGiao = nhBLL.GetAllChiTietPhieuGiao(tb_MaPN.Text);
                    dgvChiTietPhieuNhap.DataSource = dtChiTietPhieuGiao;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh chi tiết phiếu giao: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {

            string maPN;
            Random random = new Random();
            maPN = "PG" + random.Next(1000, 10000).ToString("D4");
            tb_MaPN.Text = maPN;
            tb_ThanhTien.Text = "0";

        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPD = tb_MaPhieuDat.Text;
                if (string.IsNullOrEmpty(MaPD))
                {
                    MessageBox.Show("Mã Phiếu Đặt Không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool result = nhBLL.AddPhieuNhap(tb_MaPN.Text, (int)number_LanGiao.Value, MaPD, "NV001");

                if (result)
                {
                    MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPhieuGiao();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ConvertListToDataTable(List<ChiTietPhieuGiao> listCtpg)
        {
            DataTable tb = new DataTable();

            // 1. Tạo cấu trúc cột cho DataTable
            tb.Columns.Add("MaPhieuGiao", typeof(string));
            tb.Columns.Add("MaSP", typeof(string));
            tb.Columns.Add("TenSP", typeof(string));
            tb.Columns.Add("SoLuongGiao", typeof(int));
            tb.Columns.Add("GiaNhap", typeof(decimal));
            tb.Columns.Add("TongTien", typeof(decimal));

            // 2. Duyệt qua danh sách và thêm dữ liệu vào DataTable
            foreach (var item in listCtpg)
            {
                tb.Rows.Add(item.MaPhieuGiao, item.MaSP, item.TenSP, item.SoLuongGiao, item.GiaNhap, item.TongTien);
            }

            return tb;
        }
        private decimal TongThanhTien;
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaPN = tb_MaPN.Text;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                ChiTietPhieuGiao ct = new ChiTietPhieuGiao();
                bool isChecked = row.Cells[0].Value != null && (bool)row.Cells[0].Value;
                if (isChecked)
                {
                    ct.MaPhieuGiao = MaPN;
                    ct.MaSP = row.Cells[1].Value.ToString();
                    ct.TenSP = row.Cells[2].Value.ToString();
                    ct.SoLuongGiao = 1;
                    ct.GiaNhap = nhBLL.GetGiaSanPhamTrongPhieuDat(tb_MaPhieuDat.Text, ct.MaSP);
                    ct.TongTien = ct.GiaNhap * ct.SoLuongGiao;
                    TongThanhTien += ct.TongTien;
                    var ctpd = lsCTPG.FirstOrDefault(t => t.MaSP == ct.MaSP);
                    if(ctpd != null)
                    {
                        MessageBox.Show("Sản phẩm có mã " + ct.MaSP + " đã tồn tại trong chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lsCTPG.Add(ct);
                    }    
                    row.Cells[0].Value = false;
                }
            }
            tb_ThanhTien.Text = TongThanhTien.ToString();
            loadChiTietSanPham(lsCTPG);
        }

        private decimal TinhTongTien()
        {
             TongThanhTien = 0;
            foreach (DataGridViewRow row in dgvChiTietPhieuNhap.Rows)
            {
                // Kiểm tra nếu dòng không phải dòng mới (empty row)
                if (!row.IsNewRow)
                {
                    // Lấy giá trị của ô giá và số lượng với kiểm tra null
                    int soLuong = row.Cells[4].Value != null ? Convert.ToInt32(row.Cells[4].Value) : 0;    // Cột thứ 5 (Số lượng)
                    decimal gia = row.Cells[5].Value != null ? Convert.ToDecimal(row.Cells[3].Value) : 0;  // Cột thứ 4 (Giá)


                    // Tính tổng tiền
                    TongThanhTien += gia * soLuong;
                }
            }
            return TongThanhTien;
        }

        private void loadChiTietSanPham(List<ChiTietPhieuGiao> listCtpg)
        {
            try
            {
                DataTable tbCTSP = ConvertListToDataTable(listCtpg);
                dgvChiTietPhieuNhap.DataSource = tbCTSP;
            }
            catch
            {
                MessageBox.Show("thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
            //ThanhTien();
            //tb_ThanhTien.Text = thanhTien.ToString();
        }

        private void dgvChiTietPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int SoLuong;
            decimal Gia,TongTien;
              if (e.RowIndex >= 0 && dgvChiTietPhieuNhap.Columns[e.ColumnIndex].Name == "SoLuongGiao")
                {
                    var row = dgvChiTietPhieuNhap.Rows[e.RowIndex];
                    SoLuong = int.Parse(row.Cells["SoLuongGiao"].Value.ToString());
                    Gia = Decimal.Parse(row.Cells["GiaNhap"].Value.ToString());
                    TongTien = SoLuong * Gia;
                    row.Cells["TongTien"].Value = TongTien;
                    tb_ThanhTien.Text = TinhTongTien().ToString();
                    var ctpd = lsCTPG.FirstOrDefault(ct => ct.MaSP == IdSanPham);
                    if (ctpd != null)
                    {
                        ctpd.SoLuongGiao = SoLuong;
                        ctpd.TongTien = TongTien;
                    }
            }
              if (e.RowIndex >= 0 && dgvChiTietPhieuNhap.Columns[e.ColumnIndex].Name == "GiaNhap")
              {
                  var row = dgvChiTietPhieuNhap.Rows[e.RowIndex];
                  SoLuong = int.Parse(row.Cells["SoLuongGiao"].Value.ToString());
                  Gia = Decimal.Parse(row.Cells["GiaNhap"].Value.ToString());
                  TongTien = SoLuong * Gia;
                  row.Cells["TongTien"].Value = TongTien;
                tb_ThanhTien.Text = TinhTongTien().ToString();
                var ctpd = lsCTPG.FirstOrDefault(ct => ct.MaSP == IdSanPham);
                if (ctpd != null)
                {
                    ctpd.SoLuongGiao = SoLuong;
                    ctpd.TongTien = TongTien;
                }
            }

        }

        private void btn_LuuChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            string mapn = string.Empty, masp = string.Empty;
            int soluong = 0;
            decimal gia = 0;
            decimal TongTien = 0;

            try
            {
                foreach (DataGridViewRow row in dgvChiTietPhieuNhap.Rows)
                {
                    // Kiểm tra dòng không phải là dòng trống cuối cùng
                    if (!row.IsNewRow)
                    {
                        // Kiểm tra và gán giá trị từ ô
                        if (row.Cells[0].Value != null && row.Cells[1].Value != null &&
                            row.Cells[3].Value != null && row.Cells[4].Value != null)
                        {
                            mapn = row.Cells[0].Value.ToString();
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

                            // Tính tổng tiền
                            TongTien += soluong * gia;

                            // Gọi các phương thức thêm và cập nhật
                            nhBLL.AddChiTietPhieuNhap(mapn, masp, soluong, gia);
                            nhBLL.UpdateSoLuongTonSanPham(masp, soluong);
                        }
                        else
                        {
                            MessageBox.Show($"Dòng {row.Index + 1} chứa dữ liệu không đầy đủ. Vui lòng kiểm tra lại!",
                                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // Cập nhật thành tiền cho phiếu nhập
                nhBLL.UpdateThanhTienPhieuGiao(mapn, TongTien);

                // Hiển thị thông báo và làm mới dữ liệu
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadPhieuGiao();
                lsCTPG.Clear();
                LoadSanPham();
                tb_MaPhieuDat.Text= string.Empty;
                tb_ThanhTien.Text= string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập thất bại! " + ex.Message,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_HuyPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                 nhBLL.DeletePhieuNhap(tb_MaPN.Text);
                 MessageBox.Show("Xóa Phiếu Nhập Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 loadPhieuGiao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Phiếu Nhập Thất Bại!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_TimKiemSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSP = nhBLL.GetAllSanPham(tb_TimKiemSP.Text);
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

        private void tb_MaPhieuDat_TextChanged(object sender, EventArgs e)
        {
            loadPhieuGiao();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateNgayBatDau.Value.Date;
            DateTime endDate = dateNgayKetThuc.Value.Date;
            try
            {
                DataTable dtPG = nhBLL.GetAllPhieuGiaoTheoNgay(startDate, endDate);
                dgvPhieuNhap.DataSource = dtPG;

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_XoaChiTietSanPham_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa sản phẩm với ID: " + IdSanPham + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lsCTPG.RemoveAll(ctpd => ctpd.MaSP == IdSanPham);
                loadChiTietSanPham(lsCTPG);
                decimal tongtien = TinhTongTien();
                tb_ThanhTien.Text = tongtien.ToString();
                MessageBox.Show($"Sản phẩm với ID: {IdSanPham} đã được xóa khỏi danh sách chi tiết phiếu nhập .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private string IdSanPham;
        private void dgvChiTietPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexSelect = e.RowIndex;
                DataGridViewRow data = dgvChiTietPhieuNhap.Rows[indexSelect];
                IdSanPham = data.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
    }
}

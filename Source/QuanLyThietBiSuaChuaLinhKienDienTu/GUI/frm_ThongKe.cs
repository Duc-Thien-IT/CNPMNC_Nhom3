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
using DTO;

namespace GUI
{
    public partial class frm_ThongKe : Form
    {
        ThongKe_BLL thongKe;
        public frm_ThongKe()
        {
            InitializeComponent();
            thongKe = new ThongKe_BLL();
            AutoResizeDataGridView(dgvOrdersByStatus);
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
        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            if (startDate > endDate)
            {
                // endDate nhỏ hơn startDate, hiển thị thông báo lỗi
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string loaiHoaDon = "HoaDon"; // Mặc định là hóa đơn bình thường
            if (radHoaDonSuaChua.Checked)
            {
                loaiHoaDon = "SuaChua";
            }
            else if (radHoaDonDoiTra.Checked)
            {
                loaiHoaDon = "DoiTra";
            }

            // Lấy danh sách hóa đơn từ DAL
            List<HoaDonDTO> danhSachHoaDon = thongKe.LayHoaDonTheoThoiGian(startDate, endDate, loaiHoaDon);

            // Hiển thị danh sách vào DataGridView
            dgvOrdersByStatus.DataSource = danhSachHoaDon;

            // Ẩn các cột không cần thiết
            if (loaiHoaDon == "SuaChua" || loaiHoaDon == "DoiTra")
            {
                dgvOrdersByStatus.Columns["LoaiLinhKien"].Visible = false;
                dgvOrdersByStatus.Columns["MoTa"].Visible = false;
                dgvOrdersByStatus.Columns["TongTien"].Visible = false;
            }
            else
            {
                dgvOrdersByStatus.Columns["LoaiLinhKien"].Visible = false;
                dgvOrdersByStatus.Columns["MoTa"].Visible = false;
                dgvOrdersByStatus.Columns["TongTien"].Visible = false;
            }

            // Định dạng cột ThanhTien với định dạng số có dấu phân cách ngàn
            if (dgvOrdersByStatus.Columns.Contains("ThanhTien"))
            {
                dgvOrdersByStatus.Columns["ThanhTien"].DefaultCellStyle.Format = "N0"; // "N0" là định dạng số không thập phân
            }


            // Tính tổng số đơn hàng và tổng doanh thu
            int totalOrders = thongKe.LayTongSoDonHang(startDate, endDate, loaiHoaDon);
            decimal totalRevenue = thongKe.LayTongDoanhThu(startDate, endDate, loaiHoaDon);

            // Hiển thị vào Label
            lblTotalOrders.Text = $"Tổng số đơn hàng từ {startDate.ToShortDateString()} đến {endDate.ToShortDateString()}: {totalOrders}";
            lblTotalRevenue.Text = $"Tổng doanh thu từ {startDate.ToShortDateString()} đến {endDate.ToShortDateString()}: {totalRevenue:N0} VNĐ";
        }

    }
}

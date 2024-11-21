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
    public partial class frm_DatHang : Form
    {
        private readonly DatHang_BLL dhBLL;
        List<ChiTietPhieuDat> lsCTDH = new List<ChiTietPhieuDat>();
        public frm_DatHang()
        {
            dhBLL = new DatHang_BLL();
            InitializeComponent();
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
                    if(dgvChiTietPhieuDat.DataSource != null)
                    {
                        dgvChiTietPhieuDat.DataSource = null;
                    }
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
            string mapd, masp;
            int soluong;
            decimal gia;
            decimal TongTien = 0;
            try
            {
                foreach (DataGridViewRow row in dgvChiTietPhieuDat.Rows)
                {
                    mapd = row.Cells[0].Value.ToString();
                    masp = row.Cells[1].Value.ToString();
                    soluong = int.Parse(row.Cells[3].Value.ToString());
                    gia = Decimal.Parse(row.Cells[4].Value.ToString());
                    dhBLL.AddChiTietPhieuDat(mapd, masp, soluong, gia);
                    TongTien += soluong * gia;
                }
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dhBLL.UpdaetThanhTienPhieuDat(tb_MaPhieuDat.Text, TongTien);
                loadPhieuDat();
                lsCTDH.Clear();
                dgvChiTietPhieuDat.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập thất bại!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                    ct.Gia = Decimal.Parse(row.Cells[3].Value.ToString());
                    ct.TongTien = ct.Gia * ct.SoLuongDat;
                    lsCTDH.Add(ct);
                    row.Cells[0].Value = false;
                }
            }
            loadChiTietSanPham(lsCTDH);
        }

        private void loadChiTietSanPham(List<ChiTietPhieuDat> listCtpd)
        {
            try
            {
                dgvChiTietPhieuDat.DataSource = null;
                dgvChiTietPhieuDat.DataSource = listCtpd;
            }
            catch
            {
                MessageBox.Show("thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //ThanhTien();
            //tb_ThanhTien.Text = thanhTien.ToString();
        }

        private void dgvChiTietPhieuDat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int SoLuong;
            decimal Gia, TongTien;
            if (e.RowIndex >= 0 && dgvChiTietPhieuDat.Columns[e.ColumnIndex].Name == "SoLuongDat")
            {
                var row = dgvChiTietPhieuDat.Rows[e.RowIndex];
                SoLuong = int.Parse(row.Cells["SoLuongDat"].Value.ToString());
                Gia = Decimal.Parse(row.Cells["Gia"].Value.ToString());
                TongTien = SoLuong * Gia;
                row.Cells["TongTien"].Value = TongTien;
            }
            if (e.RowIndex >= 0 && dgvChiTietPhieuDat.Columns[e.ColumnIndex].Name == "Gia")
            {
                var row = dgvChiTietPhieuDat.Rows[e.RowIndex];
                SoLuong = int.Parse(row.Cells["SoLuongDat"].Value.ToString());
                Gia = Decimal.Parse(row.Cells["Gia"].Value.ToString());
                TongTien = SoLuong * Gia;
                row.Cells["TongTien"].Value = TongTien;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}

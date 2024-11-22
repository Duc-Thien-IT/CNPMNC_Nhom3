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
    public partial class frm_NhapHang : Form
    {
        private readonly NhapHang_BLL nhBLL;
        List<ChiTietPhieuGiao> lsCTPG = new List<ChiTietPhieuGiao>();
        public frm_NhapHang()
        {
            nhBLL = new NhapHang_BLL();
            InitializeComponent();
        }

        private void frm_NhapHang_Load(object sender, EventArgs e)
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

            loadPhieuGiao();


        }


        private void loadPhieuGiao()
        {
            dgvPhieuNhap.DataSource = null;
            dgvChiTietPhieuNhap.DataSource = null;
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
                    dgvChiTietPhieuNhap.DataSource = null;
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
                    ct.Gia = nhBLL.GetGiaSanPhamTrongPhieuDat(tb_MaPhieuDat.Text, ct.MaSP);
                    ct.TongTien = ct.Gia * ct.SoLuongGiao;
                    lsCTPG.Add(ct);
                    row.Cells[0].Value = false;
                }
            }
            loadChiTietSanPham(lsCTPG);
        }

        decimal thanhTien;
        decimal ThanhTien()
        {
            thanhTien = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                // Kiểm tra nếu điều khiển là UserControl
                if (dgvSanPham.Rows.Count > 0)
                {
                    //thanhTien += itemChiTietPN.SoLuong * itemChiTietPN.Gia;
                }
            }
            return thanhTien;
        }

        private void loadChiTietSanPham(List<ChiTietPhieuGiao> listCtpg)
        {
            try
            {
                dgvChiTietPhieuNhap.DataSource = null;

                dgvChiTietPhieuNhap.DataSource = listCtpg;
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
                    Gia = Decimal.Parse(row.Cells["Gia"].Value.ToString());
                    TongTien = SoLuong * Gia;
                    row.Cells["TongTien"].Value = TongTien;
                }
              if (e.RowIndex >= 0 && dgvChiTietPhieuNhap.Columns[e.ColumnIndex].Name == "GiaNhap")
              {
                  var row = dgvChiTietPhieuNhap.Rows[e.RowIndex];
                  SoLuong = int.Parse(row.Cells["SoLuongGiao"].Value.ToString());
                  Gia = Decimal.Parse(row.Cells["Gia"].Value.ToString());
                  TongTien = SoLuong * Gia;
                  row.Cells["TongTien"].Value = TongTien;
              }

        }

        private void btn_LuuChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            //lsCTPG.Clear();
            //dgvChiTietPhieuNhap= null;
            string mapn,masp;
            int soluong;
            decimal gia;
            decimal TongTien = 0;
            try
            {
                foreach (DataGridViewRow row in dgvChiTietPhieuNhap.Rows)
                {
                    mapn = row.Cells[0].Value.ToString();
                    masp = row.Cells[1].Value.ToString();
                    soluong = int.Parse(row.Cells[3].Value.ToString());
                    gia = Decimal.Parse(row.Cells[4].Value.ToString());
                    TongTien += soluong * gia;
                    nhBLL.AddChiTietPhieuNhap(mapn, masp, soluong, gia);
                }
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                loadPhieuGiao();
                lsCTPG.Clear();
                dgvChiTietPhieuNhap = null;
            }
			catch (Exception ex)
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập thất bại!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

      
    }
}

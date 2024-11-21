using DAL;
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
    public partial class frm_Khac : Form
    {
        private readonly NhaCungCap_DAL NCCBLL;
        public frm_Khac()
        {
            InitializeComponent();
            NCCBLL = new NhaCungCap_DAL();

            LoadNhaCungCap();
        }
        public void LoadNhaCungCap()
        {
            DataTable dt = NCCBLL.GetAllNhaCungCap();
            dgv_NhaCungCap.DataSource = dt;

            dgv_NhaCungCap.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            dgv_NhaCungCap.Columns["Email"].HeaderText = "Email";
            dgv_NhaCungCap.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgv_NhaCungCap.Columns["DiaChi"].HeaderText = "Địa Chỉ";

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNCC = txt_TenNCC.Text;
                if (string.IsNullOrEmpty(tenNCC))
                {
                    MessageBox.Show("Tên nhà cung cấp  không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               string diachi =txt_DiaChi.Text;
                if (string.IsNullOrEmpty(diachi))
                {
                    MessageBox.Show("Địa chỉ  không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string email =txt_Email.Text;
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Email  không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sdt = txt_SDT.Text;  
                if (string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Số Điện Thoại  không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                bool result = NCCBLL.AddNhaCungCap(tenNCC,email,sdt,diachi);

                if (result)
                {
                    MessageBox.Show("Thêm nhà cung cấp  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp  thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
           txt_TenNCC.Clear();
           txt_SDT.Clear();
           txt_Email.Clear();
           txt_DiaChi.Clear();

        }

        private void dgv_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NhaCungCap.Rows[e.RowIndex];

                txt_NCC.Text = row.Cells["MaNCC"].Value.ToString();
                txt_TenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
               
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = txt_NCC.Text;  // Lấy mã sản phẩm cần sửa
                string tenNCC = txt_TenNCC.Text;
                string Email = txt_Email.Text;
                string SDT = txt_SDT.Text;
                string DiaChi = txt_DiaChi.Text;              

                bool result = NCCBLL.UpdateNhaCungCap(maNCC,tenNCC,Email,SDT,DiaChi);

                if (result)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadNhaCungCap(); 
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà cung cấp  thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = txt_NCC.Text;
                bool result = NCCBLL.DeleteNhaCungCap(maNCC);
                if (result)
                {
                    MessageBox.Show("Nhà cung cấp  đã được ẩn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Lỗi khi ẩn nhà cung cấp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string TenNCC = txt_TimKiem.Text.Trim();

                if (string.IsNullOrEmpty(TenNCC))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dttk = NCCBLL.SearchNhaCungCap(TenNCC);

                if (dttk == null || dttk.Rows.Count == 0)
                {
                    MessageBox.Show("Nhà cung cấp này không có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_NhaCungCap.DataSource = null;
                }
                else
                {
                    dgv_NhaCungCap.DataSource = dttk;


                    dgv_NhaCungCap.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
                    dgv_NhaCungCap.Columns["Email"].HeaderText = "Email";
                    dgv_NhaCungCap.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dgv_NhaCungCap.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Moi_Click(object sender, EventArgs e)
        {
            LoadNhaCungCap();

        }
    }
}

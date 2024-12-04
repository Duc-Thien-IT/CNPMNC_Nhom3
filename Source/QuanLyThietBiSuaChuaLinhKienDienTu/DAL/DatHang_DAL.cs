using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DatHang_DAL
    {
        private readonly ConnectDB db;
        public DatHang_DAL()
        {
            db = new ConnectDB();
        }

        public DataTable GetAllNhaCungCap()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM NhaCungCap";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy nhà cung cấp: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable GetAllPhieuDat()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM PhieuDat";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy phiếu đặt: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable GetAllChiTietPhieuDat(string MaPhieuDat)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT ct.MaPhieuDat,sp.MaSP, sp.TenSP, ct.DonGia, ct.SoLuongDat, (ct.DonGia * ct.SoLuongDat) as 'TongTien' " +
                               "FROM PhieuDat pd " +
                               "INNER JOIN ChiTietPhieuDat ct ON pd.MaPhieuDat = ct.MaPhieuDat " +
                               "INNER JOIN SanPham sp ON ct.MaSP = sp.MaSP " +
                               "WHERE pd.MaPhieuDat = @MaPhieuDat";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public DataTable GetAllSanPham(string search)
        {
            if (search == string.Empty)
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = "SELECT MaSP,TenSP,Gia,SoLuongTon,ThoiGianBaoHanh FROM SanPham WHERE Xoa = @Xoa";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Xoa", true);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            else
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = "SELECT MaSP,TenSP,Gia,SoLuongTon,ThoiGianBaoHanh FROM SanPham WHERE Xoa = @Xoa AND  (MaSP = @search OR TenSP = @search)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Xoa", true);
                    cmd.Parameters.AddWithValue("@search", search);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public string TaoMaPhieuDatMoi()
        {
            // Tiền tố cho mã phiếu đặt
            string maPhieuDatPrefix = "PD";

            // Lấy số thứ tự mã phiếu đặt mới nhất từ cơ sở dữ liệu
            string query = "SELECT TOP 1 MaPhieuDat FROM PhieuDat WHERE MaPhieuDat LIKE @MaPhieuDatPrefix ORDER BY MaPhieuDat DESC";

            using (SqlConnection conn = db.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                try
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@MaPhieuDatPrefix", maPhieuDatPrefix + "%");

                        var result = command.ExecuteScalar();

                        // Nếu không có mã phiếu đặt nào, bắt đầu từ 001
                        if (result == null)
                        {
                            return maPhieuDatPrefix + "001";
                        }
                        else
                        {
                            // Lấy số thứ tự từ mã phiếu đặt mới nhất
                            string maPhieuDatMoi = result.ToString();
                            string soThuTuCu = maPhieuDatMoi.Substring(maPhieuDatPrefix.Length);

                            // Tăng số thứ tự lên 1
                            int soThuTuMoi = int.Parse(soThuTuCu) + 1;

                            // Đảm bảo số thứ tự có 3 chữ số
                            string soThuTuMoiString = soThuTuMoi.ToString("D3");

                            // Trả về mã phiếu đặt mới
                            return maPhieuDatPrefix + soThuTuMoiString;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Lỗi khi tạo mã phiếu đặt: " + ex.Message);
                    return null;
                }
            }
        }


        public bool AddPhieuDat(string MaDat, string MaNCC, string MaNV)
        {
            DateTime ngayHienTai = DateTime.Today;
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO PhieuDat (MaPhieuDat, NgayDat,ThanhTien, MaNCC, MaNV) " +
                               "VALUES (@MaPhieuDat, @NgayDat, @ThanhTien, @MaNCC, @MaNV)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuDat", MaDat);
                cmd.Parameters.AddWithValue("@NgayDat", ngayHienTai);
                cmd.Parameters.AddWithValue("@ThanhTien", 0);
                cmd.Parameters.AddWithValue("@MaNCC", MaNCC);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine("SQL Error: " + sqlEx.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Error: " + ex.Message);
                    return false;
                }
            }
        }



        public bool AddChiTietPhieuDat(string MaPhieuDat, string MaSP, int SoLuongDat, decimal DonGia)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO ChiTietPhieuDat (MaPhieuDat, MaSP, SoLuongDat,DonGia) " +
                               "VALUES (@MaPhieuDat, @MaSP, @SoLuongDat, @DonGia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
                cmd.Parameters.AddWithValue("@SoLuongDat", SoLuongDat);
                cmd.Parameters.AddWithValue("@DonGia", DonGia);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine("SQL Error: " + sqlEx.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateThanhTien(string maPD, decimal thanhTien)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE PhieuDat SET ThanhTien = @thanhTien where MaPhieuDat = @maPD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maPD", maPD);
                cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }



        public bool DeletePhieuDatVaChiTiet(string MaPhieuDat)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Xóa từ bảng ChiTietPhieuGiao
                    string deleteChiTietQuery = "DELETE FROM ChiTietPhieuDat WHERE MaPhieuDat = @MaPhieuDat";
                    SqlCommand deleteChiTietCmd = new SqlCommand(deleteChiTietQuery, conn, transaction);
                    deleteChiTietCmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
                    deleteChiTietCmd.ExecuteNonQuery();

                    // Xóa từ bảng PhieuGiaoHang
                    string deletePhieuGiaoQuery = "DELETE FROM PhieuDat WHERE MaPhieuDat = @MaPhieuDat";
                    SqlCommand deletePhieuGiaoCmd = new SqlCommand(deletePhieuGiaoQuery, conn, transaction);
                    deletePhieuGiaoCmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
                    deletePhieuGiaoCmd.ExecuteNonQuery();

                    // Xác nhận giao dịch
                    transaction.Commit();
                    return true;
                }
                catch (SqlException sqlEx)
                {
                    // Hủy bỏ giao dịch nếu có lỗi
                    Console.WriteLine("SQL Error: " + sqlEx.Message);
                    transaction.Rollback();
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Error: " + ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }







    }
}

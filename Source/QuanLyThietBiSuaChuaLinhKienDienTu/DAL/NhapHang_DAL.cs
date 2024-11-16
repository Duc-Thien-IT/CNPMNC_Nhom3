using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhapHang_DAL
    {
        private readonly ConnectDB db;
        public NhapHang_DAL()
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
                    Console.WriteLine("Lỗi khi lấy danh sách nhà cung cấp: " + ex.Message);
                    return null;
                }
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

        public DataTable GetAllPhieuGiao(string maPD)
        {
            if (maPD != string.Empty)
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = "SELECT MaPhieuGiao,MaPhieuDat,NgayGiao,LanGiao,ThanhTien,nv.TenNV FROM PhieuGiaoHang pn INNER JOIN NhanVien nv ON nv.MaNV = pn.MaNV Where MaPhieuDat = @maPD";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maPD", maPD);

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
                    string query = "SELECT MaPhieuGiao,MaPhieuDat,NgayGiao,LanGiao,ThanhTien,nv.TenNV FROM PhieuGiaoHang pn INNER JOIN NhanVien nv ON nv.MaNV = pn.MaNV";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            
        }

        public DataTable GetAllChiTietPhieuGiao(string MaPhieuGiao)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT ct.MaPhieuGiao,sp.MaSP, sp.TenSP, sp.Gia, ct.SoLuongGiao, (sp.Gia * ct.SoLuongGiao) as 'TongTien' " +
                               "FROM PhieuGiaoHang pg " +
                               "INNER JOIN ChiTietPhieuGiao ct ON pg.MaPhieuGiao = ct.MaPhieuGiao " +
                               "INNER JOIN SanPham sp ON ct.MaSP = sp.MaSP " +
                               "WHERE pg.MaPhieuGiao = @MaPhieuGiao";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuGiao", MaPhieuGiao);
                SqlDataAdapter da = new SqlDataAdapter(cmd); 
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public decimal GetGiaSanPhamTrongPhieuDat(string MaPhieuDat, string MaSanPham)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT dbo.ChiTietPhieuDat.DonGia " +
                               "FROM dbo.ChiTietPhieuDat INNER JOIN " +
                               "dbo.ChiTietPhieuGiao ON dbo.ChiTietPhieuDat.MaSP = dbo.ChiTietPhieuGiao.MaSP INNER JOIN " +
                               "dbo.PhieuDat ON dbo.ChiTietPhieuDat.MaPhieuDat = dbo.PhieuDat.MaPhieuDat INNER JOIN " +
                               "dbo.PhieuGiaoHang ON dbo.ChiTietPhieuGiao.MaPhieuGiao = dbo.PhieuGiaoHang.MaPhieuGiao AND dbo.PhieuDat.MaPhieuDat = dbo.PhieuGiaoHang.MaPhieuDat INNER JOIN " +
                               "dbo.SanPham ON dbo.ChiTietPhieuDat.MaSP = dbo.SanPham.MaSP AND dbo.ChiTietPhieuGiao.MaSP = dbo.SanPham.MaSP " +
                               "WHERE dbo.ChiTietPhieuDat.MaPhieuDat = @MaPhieuDat AND dbo.ChiTietPhieuDat.MaSP = @MaSanPham";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
                cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham);

                conn.Open();
                object result = cmd.ExecuteScalar(); // Lấy giá trị đầu tiên từ truy vấn

                conn.Close();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
                else
                {
                    return 0; // Hoặc một giá trị mặc định tùy theo yêu cầu của bạn
                }
            }
        }


        public bool AddPhieuNhap(string MaPN, int LanGiao, string MaPhieuDat, string MaNV)
        {
            DateTime ngayHienTai = DateTime.Today;
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO PhieuGiaoHang (MaPhieuGiao, NgayGiao, LanGiao, MaPhieuDat, ThanhTien, MaNV) " +
                               "VALUES (@MaPhieuGiao, @NgayGiao, @LanGiao, @MaPhieuDat, @ThanhTien, @MaNV)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuGiao", MaPN);
                cmd.Parameters.AddWithValue("@NgayGiao", ngayHienTai);
                cmd.Parameters.AddWithValue("@LanGiao", LanGiao);
                cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
                cmd.Parameters.AddWithValue("@ThanhTien", 0);
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

        public bool AddChiTietPhieuNhap(string MaPN, string MaSP, int SoLuongGiao,decimal Gia)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO ChiTietPhieuGiao (MaPhieuGiao, MaSP, SoLuongGiao,Gia) " +
                               "VALUES (@MaPhieuGiao, @MaSP, @SoLuongGiao, @Gia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuGiao", MaPN);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
                cmd.Parameters.AddWithValue("@SoLuongGiao", SoLuongGiao);
                cmd.Parameters.AddWithValue("@Gia", Gia);

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

        public bool UpdateChiTietPhieuNhap(string maSP, string tenSP, decimal gia, int thoiGianBaoHanh, string maDanhMuc)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE SanPham SET TenSP = @TenSP, Gia = @Gia, ThoiGianBaoHanh = @ThoiGianBaoHanh, " +
                               "MaDanhMuc = @MaDanhMuc WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@TenSP", tenSP);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", thoiGianBaoHanh);
                cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

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

        public bool DeletePhieuGiaoVaChiTiet(string MaPN)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Xóa từ bảng ChiTietPhieuGiao
                    string deleteChiTietQuery = "DELETE FROM ChiTietPhieuGiao WHERE MaPhieuGiao = @MaPhieuGiao";
                    SqlCommand deleteChiTietCmd = new SqlCommand(deleteChiTietQuery, conn, transaction);
                    deleteChiTietCmd.Parameters.AddWithValue("@MaPhieuGiao", MaPN);
                    deleteChiTietCmd.ExecuteNonQuery();

                    // Xóa từ bảng PhieuGiaoHang
                    string deletePhieuGiaoQuery = "DELETE FROM PhieuGiaoHang WHERE MaPhieuGiao = @MaPhieuGiao";
                    SqlCommand deletePhieuGiaoCmd = new SqlCommand(deletePhieuGiaoQuery, conn, transaction);
                    deletePhieuGiaoCmd.Parameters.AddWithValue("@MaPhieuGiao", MaPN);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SanPham_DAL
    {
        private readonly ConnectDB db;

        public SanPham_DAL()
        {
            db = new ConnectDB();
        }

        public DataTable GetAllSanPham()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"SELECT sp.MaSP, sp.TenSP, sp.Gia, sp.ThoiGianBaoHanh, sp.SoLuongTon
                         FROM SanPham sp
                         WHERE sp.Xoa = @Xoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Xoa", true);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }


        // Sinh mã sản phẩm ngẫu nhiên, đảm bảo không trùng lặp
        public string GenerateRandomMaSP()
        {
            string maSP;
            Random random = new Random();

            while (true)
            {
                maSP = "SP" + random.Next(1000, 10000).ToString("D4"); 
                if (!IsMaSPExist(maSP))
                {
                    return maSP; 
                }
            }
        }

        // Kiểm tra mã sản phẩm có tồn tại không
        private bool IsMaSPExist(string maSP)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM SanPham WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public DataTable GetAllDanhMuc()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM DanhMucSanPham";
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
                    Console.WriteLine("Lỗi khi lấy danh mục: " + ex.Message);
                    return null;
                }
            }
        }

        // Thêm sản phẩm mới
        public bool AddSanPham(string tenSP, decimal gia, int soLuongTon, int thoiGianBaoHanh, string maDanhMuc)
        {
            string maSP = GenerateRandomMaSP();

            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO SanPham (MaSP, TenSP, Gia, SoLuongTon, ThoiGianBaoHanh, Xoa, MaDanhMuc) " +
                               "VALUES (@MaSP, @TenSP, @Gia, @SoLuongTon, @ThoiGianBaoHanh, @Xoa, @MaDanhMuc)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@TenSP", tenSP);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@SoLuongTon", soLuongTon);
                cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", thoiGianBaoHanh);
                cmd.Parameters.AddWithValue("@Xoa", true);
                cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

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


        // Cập nhật thông tin sản phẩm
        public bool UpdateSanPham(string maSP, string tenSP, decimal gia, int soLuongTon, int thoiGianBaoHanh, string maDanhMuc)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE SanPham SET TenSP = @TenSP, Gia = @Gia, SoLuongTon = @SoLuongTon, ThoiGianBaoHanh = @ThoiGianBaoHanh, " +
                               "MaDanhMuc = @MaDanhMuc WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@TenSP", tenSP);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@SoLuongTon", soLuongTon);
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

        // Xóa sản phẩm (ẩn sản phẩm)
        public bool DeleteSanPham(string maSP)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE SanPham SET Xoa = @Xoa WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@Xoa", false); // Đặt Xoa = false để ẩn sản phẩm

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

        // Tìm kiếm sản phẩm theo tên
        public DataTable SearchSanPham(string tenSP)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = @"SELECT sp.MaSP, sp.TenSP, sp.Gia, sp.ThoiGianBaoHanh, sp.SoLuongTon, 
                                    sp.MaDanhMuc, dm.TenDanhMuc 
                             FROM SanPham sp
                             INNER JOIN DanhMucSanPham dm ON sp.MaDanhMuc = dm.MaDanhMuc
                             WHERE sp.Xoa = @Xoa 
                             AND sp.TenSP LIKE @TenSP";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Xoa", 0);  
                    cmd.Parameters.AddWithValue("@TenSP", "%" + tenSP + "%"); 

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);  
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                dt = null;
            }

            return dt;
        }
        public DataTable GetSanPhamByMaSP(string maSP)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM SanPham WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


    }
}

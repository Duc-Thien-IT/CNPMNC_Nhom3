using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KhachHang_DAL
    {
    
        private readonly ConnectDB db;

        public KhachHang_DAL()
        {
            db = new ConnectDB();
        }

        public DataTable getAllKhachHang()
        {
            SqlConnection conn1 = db.GetConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM KhachHang ";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool AddKhachHang(string maKH, string tenKH, string email, decimal sdt, string diaChi)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO KhachHang (MaKH, TenKH, Email, SDT, DiaChi, Xoa) VALUES (@MaKH, @TenKH, @Email, @SDT, @DiaChi, 1)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@TenKH", tenKH);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool UpdateKhachHang(string maKH, string tenKH, string email, decimal sdt, string diaChi)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE KhachHang SET TenKH = @TenKH, Email = @Email, SDT = @SDT, DiaChi = @DiaChi WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@TenKH", tenKH);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool DeleteKhachHang(string maKH)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE KhachHang SET Xoa = 0 WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public DataTable SearchKhachHang(string searchTerm)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"SELECT * FROM KhachHang 
                                 WHERE Xoa = 0 AND (MaKH LIKE @SearchTerm 
                                 OR TenKH LIKE @SearchTerm 
                                 OR Email LIKE @SearchTerm 
                                 OR SDT LIKE @SearchTerm 
                                 OR DiaChi LIKE @SearchTerm)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
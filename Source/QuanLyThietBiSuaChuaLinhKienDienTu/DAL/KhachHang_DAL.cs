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
                string query = "SELECT * FROM KhachHang where Xoa=1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public string GetNextCustomerId()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT TOP 1 MaKH FROM KhachHang ORDER BY MaKH DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastId = result.ToString();
                    int number = int.Parse(lastId.Substring(2)) + 1;
                    return $"KH{number:D3}";
                }
                else
                {
                    return "KH001";
                }
            }
        }
        public bool AddKhachHang( string tenKH,  string sdt, string diaChi)
        {
            string maKH = GetNextCustomerId();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO KhachHang (MaKH, TenKH, SDT, DiaChi, Xoa) VALUES (@MaKH, @TenKH,  @SDT, @DiaChi, 1)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@TenKH", tenKH);
                
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool UpdateKhachHang(string maKH, string tenKH, string sdt, string diaChi)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE KhachHang SET TenKH = @TenKH,  SDT = @SDT, DiaChi = @DiaChi  WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@TenKH", tenKH);
               
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
                                 WHERE Xoa = 1 AND (MaKH LIKE @SearchTerm 
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
        public bool CheckSDTExists(string sdt)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @SDT AND Xoa = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SDT", sdt);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Trả về true nếu SDT đã tồn tại
            }
        }

    }
}
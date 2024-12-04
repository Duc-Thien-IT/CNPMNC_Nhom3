using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVien_DAL
    {
        private readonly ConnectDB db;

        public NhanVien_DAL()
        {
            db = new ConnectDB();
        }

        public DataTable getAllNhanVien()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM NhanVien WHERE Xoa = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string GetNextEmployeeId()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT TOP 1 MaNV FROM NhanVien ORDER BY MaNV DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastId = result.ToString();
                    int number = int.Parse(lastId.Substring(2)) + 1;
                    return $"NV{number:D3}";
                }
                else
                {
                    return "NV001";
                }
            }
        }

        public bool AddNhanVien(string tenNV, string email, string sdt, string diaChi, string gioiTinh, DateTime ngaySinh)
        {
            string maNV = GetNextEmployeeId();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"INSERT INTO NhanVien (MaNV, TenNV, Email, SDT, DiaChi,  GioiTinh, NgaySinh, Xoa) 
                                 VALUES (@MaNV, @TenNV, @Email, @SDT, @DiaChi, @GioiTinh, @NgaySinh, 1)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@TenNV", tenNV);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool UpdateNhanVien(string maNV, string tenNV, string email, string sdt, string diaChi, string maTK, string gioiTinh, DateTime ngaySinh)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"UPDATE NhanVien 
                                 SET TenNV = @TenNV, Email = @Email, SDT = @SDT, DiaChi = @DiaChi, 
                                     MaTK = @MaTK, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh 
                                 WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@TenNV", tenNV);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@MaTK", maTK);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool DeleteNhanVien(string maNV)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE NhanVien SET Xoa = 0 WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        public bool UpdateMaTK(string maNV, string maTK)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE NhanVien SET MaTK = @MaTK WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@MaTK", maTK);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        public bool IsMaTKAssigned(string maTK)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM NhanVien WHERE MaTK = @MaTK AND Xoa = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTK", maTK);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public string GetCurrentMaTK(string maNV)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT MaTK FROM NhanVien WHERE MaNV = @MaNV AND Xoa = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result == DBNull.Value ? null : result.ToString();
            }
        }
        public DataTable SearchNhanVien(string searchTerm)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"SELECT * FROM NhanVien 
                                 WHERE Xoa = 1 AND (MaNV LIKE @SearchTerm 
                                 OR TenNV LIKE @SearchTerm 
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


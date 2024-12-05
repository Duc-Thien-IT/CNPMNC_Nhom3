using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class TaiKhoan_DAL
    {
        private readonly ConnectDB db;

        public TaiKhoan_DAL()
        {
            db = new ConnectDB();
        }

        public DataTable getAllTaiKhoan()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM TaiKhoan WHERE Xoa = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool AddTaiKhoan(string tenDangNhap, string matKhau, string quyen)
        {
             string maTK = GetNextAccountId();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO TaiKhoan (MaTK, TenDangNhap, MatKhau, VaiTro, Xoa) VALUES (@MaTK, @TenDangNhap, @MatKhau, @VaiTro, 1)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTK", maTK);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@VaiTro", quyen);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool UpdateTaiKhoan(string maTK, string tenDangNhap, string matKhau, string quyen)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE TaiKhoan SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, VaiTro = @VaiTro WHERE MaTK = @MaTK";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTK", maTK);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@VaiTro", quyen);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool DeleteTaiKhoan(string maTK)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE TaiKhoan SET Xoa = 0 WHERE MaTK = @MaTK";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTK", maTK);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        public string GetNextAccountId()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT TOP 1 MaTK FROM TaiKhoan ORDER BY MaTK DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastId = result.ToString();
                    int number = int.Parse(lastId.Substring(2)) + 1;
                    return $"TK{number:D3}";
                }
                else
                {
                    return "TK001";
                }
            }
        }
        public DataTable SearchTaiKhoan(string searchTerm)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"SELECT * FROM TaiKhoan 
                                 WHERE Xoa = 1 AND (MaTK LIKE @SearchTerm 
                                 OR TenDangNhap LIKE @SearchTerm 
                                 OR VaiTro LIKE @SearchTerm)";
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

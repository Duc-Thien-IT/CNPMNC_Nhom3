using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
    
namespace DAL
{
    public class DanhMucSanPham_DAL
    {
        private readonly ConnectDB db;

        public DanhMucSanPham_DAL()
        {
            db = new ConnectDB();
        }

        public DataTable getAllDanhMucSanPham()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM DanhMucSanPham";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool AddDanhMucSanPham(string maDanhMuc, string tenDanhMuc)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO DanhMucSanPham (MaDanhMuc, TenDanhMuc) VALUES (@MaDanhMuc, @TenDanhMuc)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                cmd.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Sửa danh mục sản phẩm
        public bool UpdateDanhMucSanPham(string maDanhMuc, string tenDanhMuc)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE DanhMucSanPham SET TenDanhMuc = @TenDanhMuc WHERE MaDanhMuc = @MaDanhMuc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                cmd.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Xóa danh mục sản phẩm
        public bool DeleteDanhMucSanPham(string maDanhMuc)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "DELETE FROM DanhMucSanPham WHERE MaDanhMuc = @MaDanhMuc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}

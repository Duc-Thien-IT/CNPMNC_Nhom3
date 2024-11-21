using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCap_DAL
    {
        private readonly ConnectDB db;

        public NhaCungCap_DAL()
        {
            db = new ConnectDB();
        }

        public DataTable GetAllSanPham()
        {
           DataTable dataTable = new DataTable();
            using (SqlConnection conn = db.GetConnection())
            {
                DataTable dt = new DataTable();
                string query = @"SELECT MaSP,TenSP,Gia,SoLuongTon,ThoiGianBaoHanh,Xoa,TenDanhMuc
                         FROM SanPham sp, DanhMucSanPham dm
                         Where sp.MaDanhMuc = dm.MaDanhMuc and SoLuongTon <= 10
                        ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                
                return dt;
            }

          
        }
        private bool IsMaSPExist(string maNCC)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = @MaNCC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
        public string GenerateRandomMaSP()
        {
            string maNCC;
            Random random = new Random();

            while (true)
            {
                maNCC = "NCC" + random.Next(1000, 10000).ToString("D4");
                if (!IsMaSPExist(maNCC))
                {
                    return maNCC;
                }
            }
        }
        public DataTable GetAllNhaCungCap()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                DataTable dt = new DataTable();
                string query = @"SELECT *
                         FROM NhaCungCap "+
                         "WHERE Xoa=1";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
        }
        public bool AddNhaCungCap(string tenNCC, string email, string sdt, string diachi)
        {
            string maNCC = GenerateRandomMaSP();

            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO NhaCungCap (MaNCC, TenNCC, Email, SDT,DiaChi, Xoa) " +
                               "VALUES (@MaNCC, @TenNCC, @Email, @SDT, @DiaChi, @Xoa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                cmd.Parameters.AddWithValue("@Email",email );
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@DiaChi", diachi);
                cmd.Parameters.AddWithValue("@Xoa", true);

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
        public bool UpdateNhaCungCap(string MaNCC,string tenNCC, string email, string sdt, string diachi)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE NhaCungCap " +
                    "SET TenNCC = @TenNCC, Email = @Email, SDT = @SDT, DiaChi = @DiaChi " +
                    "WHERE MaNCC = @MaNCC ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNCC", MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                cmd.Parameters.AddWithValue("@Email",email);
                cmd.Parameters.AddWithValue("@SDT",sdt);
                cmd.Parameters.AddWithValue("@DiaChi", diachi);

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
        public bool DeleteNhaCungCap(string maNCC)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE NhaCungCap SET Xoa = @Xoa WHERE MaNCC = @MaNCC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
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
        public DataTable SearchNhaCungCap(string tenNCC)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = @"SELECT *
                             WHERE sp.Xoa = 1 
                             AND TenNCC LIKE @TenNCC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    //cmd.Parameters.AddWithValue("@Xoa", 0);
                    cmd.Parameters.AddWithValue("@TenNCC", "%" + tenNCC + "%");

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
    }
}

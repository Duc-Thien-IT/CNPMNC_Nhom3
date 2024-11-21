using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Login_DAL
    {
        private readonly ConnectDB db;
        public Login_DAL()
        {
            db = new ConnectDB();
        }
        public bool CheckLogin(string userName, string passWord)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @UserName AND MatKhau = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", passWord);

                conn.Open();
                int count = (int)cmd.ExecuteScalar(); // Sử dụng ExecuteScalar để lấy giá trị đầu tiên (số lượng).
                return count > 0;
            }
        }

    }
}

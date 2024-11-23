using System.Data.SqlClient;

namespace DAL
{
    public class ConnectDB
    {
        private string connectionString;

        public ConnectDB()
        {
            connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QL_LinhKienMayTinh;Integrated Security=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

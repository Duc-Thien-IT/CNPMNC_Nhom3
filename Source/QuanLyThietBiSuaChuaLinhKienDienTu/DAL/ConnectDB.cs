using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

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

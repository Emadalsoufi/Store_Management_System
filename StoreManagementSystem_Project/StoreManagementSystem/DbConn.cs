using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StoreManagementSystem
{
    class DbConn
    {
        public SqlConnection conn;

        public DbConn()
        {
            string cs = ConfigurationManager.ConnectionStrings["StoreDB"].ConnectionString;
            conn = new SqlConnection(cs);
        }

        public SqlConnection connect()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            return conn;
        }

        public void disconnect()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}

using System.Data.SqlClient;

namespace Library
{
    class SqlHelper
    {
        SqlConnection cn;

        public SqlHelper (string connection)
        {
            cn = new SqlConnection(connection);
        }

        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}

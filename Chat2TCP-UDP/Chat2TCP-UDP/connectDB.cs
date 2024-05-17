using System.Collections.Specialized;
using System.Data.SqlClient;

namespace Chat2TCP_UDP
{
     class connectDB
    {
        public static string strConnect = @"Data Source=LAGANIME;Initial Catalog=ChatTcpDB;Integrated Security=True";

        public static SqlConnection GetqlConnession()
        {
            return new SqlConnection(strConnect);
        }
    }
}
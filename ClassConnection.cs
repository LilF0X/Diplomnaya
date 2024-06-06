using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomnaya
{
    internal class ClassConnection
    {
        static public SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-QR1AU17;Initial Catalog=Diplomm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            sqlConnection.Open();
            return sqlConnection;
        }
    }
}

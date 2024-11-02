using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    public class DBConnection
    {
        public DBConnection()
        {

        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ROILION;Initial Catalog=sale;User Id=sa; Password=sa";
            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DBUtility
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection() ;

            conn.ConnectionString = "server=intvmsql;user id=pj01t18;password=tcstvm;database=db01t18";
            return conn;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonCSharp.database
{
    class Connector
    {
        public static SqlConnection getConnection()
        {
            SqlConnection connection = null;
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connectionStrings"].ConnectionString;
                connection = new SqlConnection(connString);

            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                return null;
            }
            return connection;
        }

        public static void closeConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                    connection.Dispose();
                    //command.Dispose();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapLonCSharp.database
{
    class IOConfig
    {
        private SqlDataAdapter dataAdapter;
        private SqlConnection connection = null;
        
       
        

        public DataTable excuteSelectQuery(String _query, SqlParameter[] _sqlParameter)
        {
            connection = Connector.getConnection();
            SqlCommand command = new SqlCommand();
            dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            dataTable = null;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = _query;
                command.Parameters.AddRange(_sqlParameter);
                //command.ExecuteNonQuery();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);

            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return dataTable;
        }

        public Boolean excuteInsertQuery(String _query, SqlParameter[] _parameter)
        {
            connection = Connector.getConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = _query;
                command.Parameters.AddRange(_parameter);
                dataAdapter.InsertCommand = command;
                dataAdapter.InsertCommand.ExecuteNonQuery();
                Console.WriteLine("excuteInsertQuery true");
            }
            catch (SqlException e)
            {
                Console.Write(e.StackTrace);
                return false;
            }finally
            {
                connection.Close();
                connection.Dispose();
            }
            return true;
        }
        public bool excuteUpdateQuery(String _query, SqlParameter[] _sqlPara)
        {
            connection = Connector.getConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = _query;
                command.Parameters.AddRange(_sqlPara);
                dataAdapter.UpdateCommand = command;
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                Console.WriteLine("ExcuteUpdateQuery true");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
                
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return true;
        }

        public bool excuteDeleteQuery(String _query, SqlParameter[] _sqlPara)
        {
            connection = Connector.getConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = _query;
                command.Parameters.AddRange(_sqlPara);
                dataAdapter.DeleteCommand = command;
                dataAdapter.DeleteCommand.ExecuteNonQuery();
                Console.WriteLine("ExcuteDeleteQuery true");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                return false;

            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return true;
        }
    }
}

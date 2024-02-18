using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FirstMVCApplication.DataServices
{
    public class DatabaseService
    {
        #region Public Methods
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                var sqlCd = GetDataCommand(sql);
                try
                {
                    var rowsAffected = sqlCd.ExecuteNonQuery();
                    DisposeCommand(sqlCd);
                    return rowsAffected;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Could not Execute NonQuery. Sql: {sql}. {ex.Message}");
            }
        }

        public DataSet GetDataSet(string sql)
        {
            var da = new SqlDataAdapter { SelectCommand = GetDataCommand(sql) };
            try
            {
                var ds = new DataSet();
                da.Fill(ds);
                DisposeCommand(da.SelectCommand);
                da.Dispose();

                return ds;
            }
            catch (SqlException ex)
            {
                DisposeCommand(da.SelectCommand);
                throw new Exception($"Could not Execute Data Command. Sql: {sql}. {ex.Message}");
            }
        }
        #endregion

        #region Private Methods
        /// <returns></returns>
        private SqlCommand GetDataCommand(string sql)
        {
            var sqlCd = new SqlCommand
            {
                CommandText = sql,
                CommandType = CommandType.Text,
                CommandTimeout = 300,
                Connection = GetDataConnection()
            };
            return sqlCd;
        }

        /// <summary>
        /// Gets a new data connection.
        /// </summary>
        /// <returns></returns>
        private SqlConnection GetDataConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            var sqlCn = new SqlConnection(connectionString);
            sqlCn.Open();
            return sqlCn;
        }

        private static void DisposeCommand(SqlCommand sqlCd)
        {
            if (sqlCd.Connection != null && sqlCd.Connection.State == ConnectionState.Open)
            {
                sqlCd.Connection.Close();
                sqlCd.Connection.Dispose();
            }
            sqlCd.Dispose();
        }
        #endregion
    }
}
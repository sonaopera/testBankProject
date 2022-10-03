using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        private readonly string connectionString;
        public DataAccess(string connString)
        {
            connectionString = connString;
        }

        public void RunQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }
        }

        public DataRow SelectDataRow(string query)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            var dataTable = new DataTable();
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            return dataTable.Rows[0];
        }

        public DataTable SelectDataTable(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                return (DataTable)reader[""];
            }
        }
    }
}

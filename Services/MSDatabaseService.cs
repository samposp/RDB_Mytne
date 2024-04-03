using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDB_Mytne.Services
{
    public class MSDatabaseService
    {
        private SqlConnection connection;
        public MSDatabaseService() {
            connection = new SqlConnection(
               "user id=sam;" +
               "password=rdb.1234;" +
               "server=rdb-mytne.database.windows.net;" +
               "Trusted_Connection=False;" +
               "database=rdb-mytne; " +
               "connection timeout=30");
        }

        public string sendSQLCommand(string sqlCommand)
        {
            try
            {
                connection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            // Create SQL command
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            command.ExecuteNonQuery();


            // Get output
            StringBuilder output = new();
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        output.Append(reader[0].ToString() + ", ");
                        output.Append(reader[1].ToString() + ", ");
                        output.Append(reader[2].ToString() + Environment.NewLine);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            // Close connection
            try
            {
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return output.ToString();
        }
    }
}

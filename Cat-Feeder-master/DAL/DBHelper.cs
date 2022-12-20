using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DAL
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand command = null;

        public static void establishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder buider = new MySqlConnectionStringBuilder();
                buider.Server = "127.0.0.1";
                buider.UserID = "root";
                buider.Password = "Denzafaradenza4";
                buider.Database = "mydb";
                buider.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(buider.ToString());
                MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("connection Failed");
            }
        }

        public static MySqlCommand runQuery(string query, string name)
        {
            try
            {
                if(connection != null)
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                    
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return command;
        }
    }
}

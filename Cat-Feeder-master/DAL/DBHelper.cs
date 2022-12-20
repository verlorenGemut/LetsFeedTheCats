using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Model1;

namespace DAL
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static void EstablishConnection()
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

        public static MySqlCommand RunQuery(string query, string Name)
        {
            try
            {
                if(connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.ExecuteNonQuery();
                    
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return cmd;
        }
    }
}

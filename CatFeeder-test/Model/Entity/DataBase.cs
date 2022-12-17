using System.Data;
using MySql.Data.MySqlClient;

namespace Model.Entity
{
    class DataBase
    {
        public MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=root;database=feeder_db;");
        public MySqlDataAdapter adapter;

        public DataBase()
        {
            connection = new MySqlConnection("server=localhost;user=root;password=Denzafaradenza4;database=feeder_db;");
            adapter = new MySqlDataAdapter();
        }

        public DataTable getAllDataWhere(string tableName, string conditions)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + tableName + " WHERE " + conditions, connection);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        /*public DataTable getSomeDataWhere(string tableName, string conditions, string strDataType)
        {
            MySqlCommand command = new MySqlCommand("SELECT " + strDataType + " FROM " + tableName + " WHERE " + conditions, connection);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }*/
        public DataTable getAllData(string tableName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + tableName, connection);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public void insertData(string tableName, string data)//working
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO " + tableName + " VALUES " + data, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
        public void insertSomeData(string tableName, string data, string nColumn)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO " + tableName + " " + nColumn + " VALUES " + data, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void updateData(string tableName, string newData, string conditions)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("UPDATE " + tableName + " SET " + newData + " WHERE " + conditions, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void deleteData(string tableName, string conditions)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM " + tableName + " WHERE " + conditions, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

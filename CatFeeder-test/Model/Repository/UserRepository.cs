using Model.Entity;
using System;

using System.Collections.Generic;
using System.Data;
/*

            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=feeder_db;");
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT user_id FROM users WHERE user_type = 1", conn);
            string test = command.ExecuteScalar().ToString();
            Console.WriteLine(test);
            Console.ReadLine();
            conn.Close();
            MessageBox.Show(test, "Notification", MessageBoxButtons.OK);
*/

namespace Model.Repository
{
    public class UserRepository : IRepository<User>
    {
        private DataBase dataBase = new DataBase();
       // private User user;

        public User getFeederFromDatabase(string username)
        {
            DataTable table = new DataTable();
            string conditions = "user_id= '" + username + "'";
            table = dataBase.getAllDataWhere("users", conditions);
            User user = new User();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var data = row.ItemArray;
                    user.strUsername = data[0].ToString();
                    user.shAccountTYpe =Convert.ToInt16(data[1]);
                    user.strPasswordHashed = data[2].ToString();
                    user.strPasswordSalt = data[3].ToString();
                }
            }
            else
                return null;

            return user;
        }

        public void removeFeederFromDatabase(User user)
        {
            string username = user.strUsername;
            string conditions = "user_id = '" + username + "'";
            dataBase.deleteData("users", conditions);
        }
        public int addFeederToDatabase(User user)
        {
            string username = user.strUsername;
            short accountType = user.shAccountTYpe;
            string passwordHash = user.strPasswordHashed;
            string passwordSalt = user.strPasswordSalt;
            string data = "('" + username + "','" + accountType + "','" + passwordHash +"','" + passwordSalt + "');";
            dataBase.insertData("users", data);
            return 0;
        }
        public void updateFeederInDatabase(User user, string conditions)
        {
            string username = user.strUsername;
            short accountType = user.shAccountTYpe;
            string passwordHash = user.strPasswordHashed;
            string passwordSalt = user.strPasswordSalt;
            string data = "user_id = '" + username + "', user_type = '" + accountType + "', user_password_hash = '" 
                + passwordHash + "', user_password_salt = '" + passwordSalt + "'";
            dataBase.updateData("users", data, conditions);
        }
        public List<User> getAllFeeders()
        {
            DataTable table = new DataTable();
            table = dataBase.getAllData("users");
            List<User> listUsers = new List<User>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    User user = new User();
                    var data = row.ItemArray;
                    user.strUsername = data[0].ToString();
                    user.shAccountTYpe = (short)data[1];
                    user.strPasswordHashed = data[2].ToString();
                    user.strPasswordSalt = data[3].ToString();
                    listUsers.Add(user);
                }
            }
            else
                return null;
            return listUsers;
        }
        /*public void Save()
        {
            throw new NotImplementedException();
        }*/

       /* public List<User> GetAll(string id)
        {
            throw new NotImplementedException();
        }*/

        public List<User> getFeedersOfUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}

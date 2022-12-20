using Model.Ententity;
using Model1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class UserRepository : IRepository<Customer>
    {
        public int add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer find(string name)
        {
            DataTable dataTable;
            MySqlDataAdapter dataAdapter;

            Customer customer = null;
            string query = "SELECT * FROM mydb.user WHERE Name = (@name) limit 1";
            MySqlCommand command = DBHelper.runQuery(query, name);
            if (command != null)
            {
                dataTable = new DataTable();
                dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                foreach(DataRow dr in dataTable.Rows)
                {
                    string userName = dr["Name"].ToString();
                    string password = dr["password"].ToString();
                    string status = dr["status"].ToString();
                    customer = new Customer(userName, password, status);
                }
            }
            return customer;
        }

        public IEnumerable<Customer> getAll()
        {
            throw new NotImplementedException();
        }

        public void remove(int id)
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            throw new NotImplementedException();
        }

        public void update(Customer customer)
        {
            throw new NotImplementedException();
        }
        
    }

}

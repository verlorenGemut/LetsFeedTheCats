using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;
using Model.Ententity;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class UserRepository : IRepository<Customer>
    {
        public int Add(Customer obj)
        {
            throw new NotImplementedException();
        }

        public Customer Find(string name)
        {
            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            Customer customer = null;
            string query = "SELECT * FROM mydb.user WHERE Name = (@name) limit 1";
            cmd = DBHelper.RunQuery(query, name);
            if(cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    string uName = dr["Name"].ToString();
                    string password = dr["password"].ToString();
                    string status = dr["status"].ToString();
                    customer = new Customer(uName, password, status);
                }
            }
            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
        
    }

}

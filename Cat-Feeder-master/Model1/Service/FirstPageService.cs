using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Ententity;
using System.Windows.Forms;

namespace Model1.Service
{
    public class FirstPageService : IFirstPageService
    {
        public event Action evUser;
        public event Action evShowAdminPage;
        public IRepository<Customer> _customer;
        private Customer customer;

        public FirstPageService(IRepository<Customer> customer)
        {
            _customer = customer;
        }
        public void createCustormer(string login, string password)
        {
            customer = _customer.find(login);
            if(customer != null)
            {
                if (customer.Password.Equals(password))
                {
                    MessageBox.Show("Successfull");
                    if (customer.Status.Equals("user"))
                    {
                        evUser?.Invoke();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                }
            }
            else
            {
                MessageBox.Show("No user yet");
            }
        
        }

        public void createAdmin(string login, string password)
        {
            customer = _customer.find(login);
            if (customer != null)
            {
                if (customer.Password.Equals(password))
                {
                    MessageBox.Show("Successfull");
                    if (customer.Status.Equals("admin"))
                    {
                        evShowAdminPage?.Invoke();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                }
            }
            else
            {
                MessageBox.Show("No admin yet");
            }
        }


    }
}

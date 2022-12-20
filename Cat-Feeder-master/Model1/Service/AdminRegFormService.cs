using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1.Service
{
    public class AdminRegFormService : IAdminRegFormService
    {
        public event Action evUserRegistered;
        public void AddUser(string login, string password)
        {
            evUserRegistered?.Invoke();

        }
    }
}

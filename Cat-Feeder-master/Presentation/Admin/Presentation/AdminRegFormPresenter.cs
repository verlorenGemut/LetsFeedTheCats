using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

using Model1;

namespace Presentation
{
    public class AdminRegFormPresenter
    {
        private readonly IKernel _kernel;
        private IAdminRegFormView _view;
        private IAdminRegFormService _service;

        public AdminRegFormPresenter(IKernel kernel, IAdminRegFormView view, IAdminRegFormService service)
        {
            _kernel = kernel;

            _view = view;
            _view.AddUser += AddUser;

            _service = service;
            _service.UserRegistered += UserRegistered;
        }

        private void AddUser(string login, string password)
        {
            _service.AddUser(login, password);
        }

        private void UserRegistered()
        {
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}

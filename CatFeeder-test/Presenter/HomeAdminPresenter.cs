using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class HomeAdminPresenter
    {
        private readonly IKernel kernel;
        private IHomeAdmin view;

        private string currentAdmin;

        public HomeAdminPresenter(IKernel kernel, IHomeAdmin view)
        {
            this.kernel = kernel;
            this.view = view;

            this.view.evShowLogOut += showLogout;
            this.view.evShowFeederIDiist += showFeederIDiist;
        }

        private void showFeederIDiist()
        {
            var presenter = kernel.Get<FeederIDlistPresenter>();
            presenter.Run(currentAdmin);
            view.Close();
        }

        private void showLogout()
        {
            var presenter = kernel.Get<LogInPresenter>();
            presenter.Run();
            view.Close();
        }
        public void Run(string username)
        {
            currentAdmin = username;
            view.Show();
        }
    }
}

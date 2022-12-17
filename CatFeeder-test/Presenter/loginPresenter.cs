using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class LogInPresenter
    {
        private readonly IKernel kernel;
        private ILogIn view;
        private IAuthService authService;


        public LogInPresenter(IKernel kernel, ILogIn view, IAuthService authservice)
        {
            this.kernel = kernel;
            this.view = view;
            authService = authservice;

            this.view.evShowLogIn += showLogIn;
            this.view.evShowRegisterScreen += showRegisterScreen;
        }

        private void showRegisterScreen()
        {
            var presenter = kernel.Get<RegistrationScreenPresenter>();
            presenter.Run();
            view.Close();
        }

        private void showLogIn(string username, string password)
        {
            short user_type = authService.logIn(username, password); //если выдаёт не 1 и не 2 ( 0 ), то данные для входа неверны
																	  //var presenter = kernel.Get<HomeSserPresenter>();
																	  //presenter.Run(username);
																	  //_view.Close();
			if (user_type == 1)
			{
				var presenter = kernel.Get<HomeUserPresenter>();
				presenter.Run(username);
				view.Close();
			}
			else if (user_type == 2)
			{
				var presenter = kernel.Get<HomeAdminPresenter>();
				presenter.Run(username);
				view.Close();
			}
			else
				MessageBox.Show("Wrong login or password!", " Try again!", MessageBoxButtons.OK); //вынести в view
		}

		public void Run()
        {
            view.Show();
        }
    }
}

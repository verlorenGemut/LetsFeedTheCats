using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class RegistrationScreenPresenter
    {
        private readonly IKernel kernel;
        private IRegistrationScreen view;
        private IAuthService authService;

        public RegistrationScreenPresenter(IKernel kernel, IRegistrationScreen view, IAuthService authService)
        {
            this.kernel = kernel;
            this.view = view;
            this.authService = authService;

            this.view.evShowLogInScreen += showLogInScreen;
            this.view.evShowRegister += showRegister;
        }

        private void showLogInScreen()
        {
            var presenter = kernel.Get<LogInPresenter>();
            presenter.Run();
            view.Close();
        }

        private void showRegister(string username, string password, string confirmPassword)
        {
            short registerResult = authService.register(username, password, confirmPassword);

            view.register_result_response(registerResult);

            if (registerResult == 0)
            {
                var presenter = kernel.Get<LogInPresenter>();
                presenter.Run();
                view.Close();
            }
            
        }

        public void Run()
        {
            view.Show();
        }
    }
}

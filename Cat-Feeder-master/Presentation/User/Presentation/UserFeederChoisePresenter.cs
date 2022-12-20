using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserFeederChoisePresenter
    {
        private readonly IKernel _kernel;
        private IUserFeederChoiseView _view;

        public UserFeederChoisePresenter(IKernel kernel, IUserFeederChoiseView view)
        {
            _kernel = kernel;

            _view = view;
            _view.ChoiseFeeder += ChoiseFeeder;
        }

        private void ChoiseFeeder()
        {
            // Выбрать кормушку
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}

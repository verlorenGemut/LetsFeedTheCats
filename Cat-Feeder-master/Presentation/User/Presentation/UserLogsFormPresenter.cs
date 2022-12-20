using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserLogsFormPresenter
    {
        private readonly IKernel _kernel;
        private IUserLogsFormView _view;

        public UserLogsFormPresenter(IKernel kernel, IUserLogsFormView view)
        {
            _kernel = kernel;

            _view = view;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}

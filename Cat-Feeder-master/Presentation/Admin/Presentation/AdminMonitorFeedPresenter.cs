using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class AdminMonitorFeedPresenter
    {
        private readonly IKernel _kernel;
        private IAdminMonitorFeedView _view;

        public AdminMonitorFeedPresenter(IKernel kernel, IAdminMonitorFeedView view)
        {
            _kernel = kernel;

            _view = view;
            _view.evChooseSensorFeeder += ChooseSensorFeeder;
            _view.evChooseDispenserFeeder += ChooseDispenserFeeder;
            _view.evChooseUser += ChooseUser;
            _view.evSaveFeeder += SaveFeedor;
            _view.evRemoveFeeder += RemoveFeedor;
            _view.evChooseFeeder += ChooseFeeder;
        }

        private void ChooseSensorFeeder()
        {

        }

        private void ChooseDispenserFeeder()
        {

        }

        private void ChooseUser()
        {

        }

        private void SaveFeedor()
        {

        }

        private void RemoveFeedor()
        {

        }

        private void ChooseFeeder()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}

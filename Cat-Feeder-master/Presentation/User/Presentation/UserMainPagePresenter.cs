using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserMainPagePresenter
    {
        private readonly IKernel _kernel;
        private IUserMainPageView _view;

        public UserMainPagePresenter(IKernel kernel, IUserMainPageView view)
        {
            _kernel = kernel;

            _view = view;
            _view.evShowFeedVeiw += ShowFeedVeiw;
            _view.evShowMakeMarkFormView += ShowMakeMarkFormView;
            _view.evShowLogsFormView += ShowLogsFormView;
            _view.evShowTimetableView += ShowTimetableView;

        }


        private void ShowFeedVeiw()
        {
            _kernel.Get<UserFeedPresenter>().Run();

        }
        private void ShowMakeMarkFormView()
        {
            _kernel.Get<UserMakeMarkFormPresenter>().Run();

        }
        private void ShowLogsFormView()
        {
            _kernel.Get<UserLogsFormPresenter>().Run();

        }
        private void ShowTimetableView()
        {
            _kernel.Get<UserTimetablePresenter>().Run();

        }

        public void Run()
        {
            _view.Show();
        }
    }
}

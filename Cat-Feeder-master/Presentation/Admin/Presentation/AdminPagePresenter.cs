using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class AdminPagePresenter
    {
        private readonly IKernel _kernel;
        private IAdminPageView _view;

        public AdminPagePresenter(IKernel kernel, IAdminPageView view)
        {
            _kernel = kernel;

            _view = view;
            _view.ShowAdminRegFormView += ShowAdminRegFormView;
            _view.ShowAdminLogsFormView += ShowAdminLogsFormView;
            _view.ShowAdminMonitorFeedView += ShowAdminMonitorFeedView;
            _view.ShowAdminTimetableView += ShowAdminTimetableView;

        }

        private void ShowAdminRegFormView()
        {
            _kernel.Get<AdminRegFormPresenter>().Run();
        }

        private void ShowAdminLogsFormView()
        {
            _kernel.Get<AdminLogsFormPresenter>().Run();
        }

        private void ShowAdminMonitorFeedView()
        {
            _kernel.Get<AdminMonitorFeedPresenter>().Run();
        }

        private void ShowAdminTimetableView()
        {
            _kernel.Get<AdminTimetablePresenter>().Run();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}

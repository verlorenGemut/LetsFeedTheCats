using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserFeedPresenter
    {
        private readonly IKernel _kernel;
        private IUserFeedView _view;

        public UserFeedPresenter(IKernel kernel, IUserFeedView view)
        {
            _kernel = kernel;

            _view = view;
            _view.SaveTimetable += SaveTimetable;
            _view.ShowExistTimetable += ShowExistTimetable;
            
        }

        private void SaveTimetable()
        {
            
        }

        private void ShowExistTimetable()
        {
            // STOOP
            // ДОБАВИТЬ НОВУЮ ФОРМУ
            _kernel.Get<UserTimetablePresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserTimetablePresenter
    {
        private readonly IKernel _kernel;
        private IUserTimetableView _view;

        public UserTimetablePresenter(IKernel kernel, IUserTimetableView view)
        {
            _kernel = kernel;

            _view = view;
            _view.ChooseFeed += ChooseFeed;
            _view.ChooseTimetable += ChooseTimetable;
            _view.ExportTimetable += ExportTimetable;
            _view.ImportTimetable += ImportTimetable;
            _view.SaveTimetable += SaveTimetable;
          
        }
        public void ChooseFeed()
        {
            _kernel.Get<UserFeederChoisePresenter>().Run();

        }

        public void ChooseTimetable()
        {
            // Обработка
        }
        public void ExportTimetable()
        {

        }

        public void ImportTimetable()
        {

        }

        public void SaveTimetable()
        {

        }
        public void Run()
        {
            _view.Show();
        }
    }
}

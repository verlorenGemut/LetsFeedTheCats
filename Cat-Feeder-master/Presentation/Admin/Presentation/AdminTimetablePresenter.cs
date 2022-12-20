using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Model1;

namespace Presentation
{
    public class AdminTimetablePresenter
    {
        private readonly IKernel _kernel;
        private IAdminTimetableView _view;
        private IAdminTimetableService _service;

        public AdminTimetablePresenter(IKernel kernel, IAdminTimetableView view, IAdminTimetableService service)
        {
            _kernel = kernel;

            _view = view;
            _view.TimetableExportAdmin += TimetableExportAdmin;
            _view.TimetableImportAdmin += TimetableImportAdmin;
            _view.TimetableСhoose += TimetableСhoose;
            _view.TimetableText += TimetableText;

            _service = service;
            _service.TimetableEvent += TimetableEvent;
        }

        private void TimetableExportAdmin()
        {

        }

        private void TimetableImportAdmin()
        {

        }

        private void TimetableСhoose(int timetable)
        {

        }

        private void TimetableText(string timetableText)
        {

        }

        private void TimetableEvent()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Model1;

namespace Presentation
{
    public class AdminLogsFormPresenter
    {
        private readonly IKernel _kernel;
        private IAdminLogsFormView _view;
        private IAdminLogsFormService _service;

        public AdminLogsFormPresenter(IKernel kernel, IAdminLogsFormView view, IAdminLogsFormService service)
        {
            _kernel = kernel;

            _view = view;
            _view.evChooseUser += ChooseUser;
            _view.evChooseLog += ChooseLog;
            _view.evPrintAllLogs += PrintAllLogs;
            _view.evExportLogs += ExportLogs;

            _service = service;
            _service.evUserChoosed += UserChoosed;
            _service.evLogChoosed += LogChoosed;
            _service.evAllLogsPrinted += AllLogsPrinted;
            _service.evLogsExported += LogsExported;

        }

        private void ChooseUser()
        {
            _service.ChooseUser();
        }

        private void ChooseLog()
        {
            _service.ChooseUser();
        }

        private void PrintAllLogs()
        {
            _service.PrintAllLogs();
        }

        private void ExportLogs()
        {
            _service.ExportLogs();
        }

        private void UserChoosed()
        {

        }

        private void LogChoosed()
        {

        }

        private void AllLogsPrinted()
        {

        }

        private void LogsExported()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}

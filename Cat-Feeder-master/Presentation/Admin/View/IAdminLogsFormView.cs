using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAdminLogsFormView : IView
    {
        
        event Action evChooseUser;
        event Action evChooseLog;
        event Action evPrintAllLogs;
        event Action evExportLogs;
    }
}

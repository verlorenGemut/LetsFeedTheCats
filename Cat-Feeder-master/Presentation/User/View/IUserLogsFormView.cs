using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IUserLogsFormView : IView
    {
        event Action evShowAllLogs;
        event Action evExportLogs;
        event Action<string> evChooseLog;
    }
}

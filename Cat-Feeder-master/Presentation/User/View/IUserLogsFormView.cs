using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IUserLogsFormView : IView
    {
        event Action ShowAllLogs;
        event Action ExportLogs;
        event Action<string> ChooseLog;
    }
}

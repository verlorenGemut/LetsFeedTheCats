using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAdminLogsFormView : IView
    {
        
        event Action ChooseUser;
        event Action ChooseLog;
        event Action PrintAllLogs;
        event Action ExportLogs;
    }
}

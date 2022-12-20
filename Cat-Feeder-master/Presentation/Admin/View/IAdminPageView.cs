using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAdminPageView: IView
    {
        event Action evShowAdminRegFormView;
        event Action evShowAdminMonitorFeedView;
        event Action evShowAdminLogsFormView;
        event Action evShowAdminTimetableView;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAdminPageView: IView
    {
        event Action ShowAdminRegFormView;
        event Action ShowAdminMonitorFeedView;
        event Action ShowAdminLogsFormView;
        event Action ShowAdminTimetableView;
    }
}

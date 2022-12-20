using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IUserMainPageView : IView
    {
        event Action evShowMakeMarkFormView;
        event Action evShowLogsFormView;
        event Action evShowTimetableView;
        event Action evShowFeedVeiw;

    }
}

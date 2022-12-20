using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IUserMainPageView : IView
    {
        event Action ShowMakeMarkFormView;
        event Action ShowLogsFormView;
        event Action ShowTimetableView;
        event Action ShowFeedVeiw;

    }
}

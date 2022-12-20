using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAdminMonitorFeedView : IView
    {
        string name { get; }

        event Action evChooseSensorFeeder;
        event Action evChooseDispenserFeeder;
        event Action evChooseUser;
        event Action evSaveFeeder;
        event Action evRemoveFeeder;
        event Action evChooseFeeder;

    }
}

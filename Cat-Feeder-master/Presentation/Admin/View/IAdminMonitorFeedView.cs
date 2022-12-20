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

        event Action ChooseSensorFeeder;
        event Action ChooseDispenserFeeder;
        event Action ChooseUser;
        event Action SaveFeedor;
        event Action RemoveFeedor;
        event Action ChooseFeeder;

    }
}

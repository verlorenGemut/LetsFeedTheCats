using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IUserFeedView : IView
    {
        string timetableName { get; }
        string timetable { get; }

        event Action SaveTimetable;
        event Action ShowExistTimetable;
        
    }
}
